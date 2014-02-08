function Pseudo_Unicode_Toy::Function_Load_Dictionary( %this )
{

%this.Simset_Dictionary=new SimSet();

//%FileObject_File=new FileObject();

%FileObject_File=new FileStreamObject();

//%Bool_Open_Result=%FileObject_File.openForRead("./JMdict_e");

%Bool_Open_Result=%FileObject_File.open("./JMdict_e","Read");

echo("openForRead():" SPC %Bool_Open_Result);

%Int_Random_Position=getRandom(0,%FileObject_File.getStreamSize()-1);

%FileObject_File.setPosition(%Int_Random_Position);

%Char_Phase_Search=-1;//Search for <entry> first.

%ScriptObject_Char=new ScriptObject()
{

String_Kanji_Or_Kana="";

String_Definition="";

String_Kana="";

};

while (!%FileObject_File.isEOF())
{

%String_Line=%FileObject_File.readLine();

echo("readLine():" SPC %String_Line);

//Look for <keb> or <reb>
//Look for <reb>
//Look for <gloss>

%Int_Counter=0;

%Word="";

%Bool_Break=false;

%Bool_Can_Add=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Char_Phase_Search==-1)//Search for <entry> first.
{
echo(%Word);
if (strstr(%Word,"<entry>")!=-1)
{

%Char_Phase_Search++;

}
else
{

%Bool_Break=true;

}

}
else if (%Char_Phase_Search==0)//Search for the Kanji or Kana.
{

if (strstr(%Word,"<keb>")!=-1||strstr(%Word,"<reb>")!=-1)
{

%Bool_Skip_Reb=false;

if (strstr(%Word,"<reb>")!=-1)
{

%Bool_Skip_Reb=true;

}

%Word=strreplace(%Word,"<keb>","");

%Word=strreplace(%Word,"<reb>","");

while (1)
{

if (strstr(%Word,"</keb>")!=-1||strstr(%Word,"</reb>")!=-1)
{

%Word=strreplace(%Word,"</keb>","");

%Word=strreplace(%Word,"</reb>","");

%ScriptObject_Char.String_Kanji_Or_Kana=trim(%ScriptObject_Char.String_Kanji_Or_Kana SPC %Word);

break;

}

%ScriptObject_Char.String_Kanji_Or_Kana=%ScriptObject_Char.String_Kanji_Or_Kana SPC %Word;

%Int_Counter++;

%Word=getWord(%String_Line,%Int_Counter);

if (%Int_Counter>strlen(%String_Line)){break;}

}

%Bool_Break=true;

if (!%Bool_Skip_Reb)
{

%Char_Phase_Search++;

}
else
{

%Char_Phase_Search+=2;

}

}

}
else if (%Char_Phase_Search==1)//Search for the Kana.
{

if (strstr(%Word,"<reb>")!=-1)
{

%Word=strreplace(%Word,"<reb>","");

while (1)
{

if (strstr(%Word,"</reb>")!=-1)
{

%Word=strreplace(%Word,"</reb>","");

%ScriptObject_Char.String_Kana=trim(%ScriptObject_Char.String_Kana SPC %Word);

break;

}

%ScriptObject_Char.String_Kana=%ScriptObject_Char.String_Kana SPC %Word;

%Int_Counter++;

%Word=getWord(%String_Line,%Int_Counter);

if (%Int_Counter>strlen(%String_Line)){break;}

}

%Bool_Break=true;

%Char_Phase_Search++;

}

}
else if (%Char_Phase_Search==2)//Search for the definition.
{

if (strstr(%Word,"<gloss>")!=-1)
{

%Word=strreplace(%Word,"<gloss>","");

while (1)
{

if (strstr(%Word,"</gloss>")!=-1)
{

%Word=strreplace(%Word,"</gloss>","");

%ScriptObject_Char.String_Definition=trim(%ScriptObject_Char.String_Definition SPC %Word);

break;

}

%ScriptObject_Char.String_Definition=%ScriptObject_Char.String_Definition SPC %Word;

%Int_Counter++;

%Word=getWord(%String_Line,%Int_Counter);

if (%Int_Counter>strlen(%String_Line)){break;}

}

%Bool_Break=true;

%Char_Phase_Search=0;

%Bool_Can_Add=true;

}

}

%Int_Counter++;

if (%Int_Counter>strlen(%String_Line)){break;}

}

if (%Bool_Can_Add)
{

%this.Simset_Dictionary.add(%ScriptObject_Char);


echo("Added:");
echo(%ScriptObject_Char.String_Kanji_Or_Kana);
echo(%ScriptObject_Char.String_Kana);
echo(%ScriptObject_Char.String_Definition);

break;

%ScriptObject_Char=new ScriptObject()
{

String_Kanji_Or_Kana="";

String_Definition="";

String_Kana="";

};

}

}

%FileObject_File.close();

echo("Finished loading dictionary into memory.");

}

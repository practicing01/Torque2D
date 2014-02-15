function Pseudo_Unicode_Toy::Function_Load_Dictionary( %this )
{

%this.Simset_Dictionary=new SimSet();

//%FileObject_File=new FileObject();

%FileObject_File=new FileStreamObject();

//%Bool_Open_Result=%FileObject_File.openForRead("./Kana_Dictionary.txt");

%Bool_Open_Result=%FileObject_File.open("./Kana_Dictionary.txt","Read");

//%Int_Random_Position=getRandom(0,%FileObject_File.getStreamSize()-1);

//%FileObject_File.setPosition(%Int_Random_Position);

//%String_Line=%FileObject_File.readLine();//Get line so the next one is complete.

/***********************************************/

%ScriptObject_Char=new ScriptObject()
{

String_Kanji_Or_Kana="";

String_Definition="";

String_Kana="";

};

/************************************************/

while (1)
{

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char.String_Kana=%String_Line;

echo("readLine():" SPC %String_Line);

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char.String_Definition=%String_Line;

echo("readLine():" SPC %String_Line);

%this.Simset_Dictionary.add(%ScriptObject_Char);

//break;//Get just one.

if (%FileObject_File.isEOF()){break;}

%ScriptObject_Char=new ScriptObject()
{

String_Kanji_Or_Kana="";

String_Definition="";

String_Kana="";

};

}

/************************************************/

%FileObject_File.close();

return;

/************************************************/

%FileObject_File_Out=new FileObject();

//%FileObject_File=new FileObject();

//%FileObject_File=new FileStreamObject();

//%Bool_Open_Result=%FileObject_File.openForRead("./JMdict_e");

//%Int_File_Counter=0;

//%Int_File_Counter2=0;

%Bool_Open_Result=%FileObject_File_Out.openForWrite("./Kana_Dictionary.txt");

%Bool_Open_Result=%FileObject_File.open("./JMdict_e","Read");

//%Int_Random_Position=getRandom(0,%FileObject_File.getStreamSize()-1);

//%FileObject_File.setPosition(%Int_Random_Position);

%Char_Phase_Search=-1;//Search for <entry> first.

%ScriptObject_Char=new ScriptObject()
{

String_Kanji_Or_Kana="";

String_Definition="";

String_Kana="";

};

while (1)
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

/*while (getSubStr(%Word,0,1)$="")
{

%Word=trim(%Word);

}

%ScriptObject_Char.String_Kanji_Or_Kana=%ScriptObject_Char.String_Kanji_Or_Kana SPC %Word;
*/
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

if (%ScriptObject_Char.String_Kana!$="")
{

%FileObject_File_Out.writeLine(trim(%ScriptObject_Char.String_Kana));

}
else
{

%FileObject_File_Out.writeLine(trim(%ScriptObject_Char.String_Kanji_Or_Kana));

}

%FileObject_File_Out.writeLine(trim(%ScriptObject_Char.String_Definition));

/*%Int_File_Counter++;

if (%Int_File_Counter>1000)
{

%Int_File_Counter=0;

%Int_File_Counter2++;

%FileObject_File_Out.close();

%Bool_Open_Result=%FileObject_File_Out.openForWrite("./kana_out/kana_out_" @ %Int_File_Counter2 @ ".txt");

}
*/
//%FileObject_File_Out.close();
//%Bool_Open_Result=%FileObject_File_Out.openForWrite("./kana_out/kana_out_" @ %Int_File_Counter @ ".txt");

//break;//Just read one entry.

%ScriptObject_Char=new ScriptObject()
{

String_Kanji_Or_Kana="";

String_Definition="";

String_Kana="";

};

}

if (%FileObject_File.isEOF()){break;}

}

%FileObject_File.close();

%FileObject_File_Out.close();

echo("Finished loading dictionary into memory.");

}

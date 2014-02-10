function Pseudo_Unicode_Toy::Function_Load_Characters( %this )
{

//Load Hiragana.

%this.Image_Asset_Object_Hiragana=new ImageAsset()
{

ExplicitMode=true;

};

%this.Image_Asset_Object_Hiragana.setImageFile("./Hiragana_0.png");

%this.Image_Asset_ID_Hiragana=AssetDatabase.addPrivateAsset(%this.Image_Asset_Object_Hiragana);

/***************************************************************************/

%this.Simset_Map_Hiragana=new SimSet();

%FileObject_File=new FileObject();

echo("openForRead():" SPC %FileObject_File.openForRead("./Hiragana.fnt"));

//Get past first 4 lines.
for (%x=0;%x<4;%x++)
{

%String_Line=%FileObject_File.readLine();

}

%Int_Frame_Counter=0;

while (!%FileObject_File.isEOF())
{

%ScriptObject_Char=new ScriptObject()
{

ID_Unicode=0;

Vector_2D_Texture_Position="0 0";

Vector_2D_Size="0 0";

Image_Asset=0;

Frame=0;

};

%String_Line=%FileObject_File.readLine();

//echo("readLine():" SPC %String_Line);

%Int_Counter=1;

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"id=");

%ScriptObject_Char.ID_Unicode=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"x=");

%ScriptObject_Char.Vector_2D_Texture_Position.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"y=");

%ScriptObject_Char.Vector_2D_Texture_Position.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"width=");

%ScriptObject_Char.Vector_2D_Size.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"height=");

%ScriptObject_Char.Vector_2D_Size.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%ScriptObject_Char.Image_Asset=%this.Image_Asset_ID_Hiragana;

%this.Image_Asset_Object_Hiragana.addExplicitCell
(
%ScriptObject_Char.Vector_2D_Texture_Position.X,
%ScriptObject_Char.Vector_2D_Texture_Position.Y,
%ScriptObject_Char.Vector_2D_Size.X,
%ScriptObject_Char.Vector_2D_Size.Y
);

%ScriptObject_Char.Frame=%Int_Frame_Counter;

%Int_Frame_Counter++;

/***********************************************/

%this.Simset_Map_Hiragana.add(%ScriptObject_Char);

//echo("Added" SPC %ScriptObject_Char.ID_Unicode SPC %ScriptObject_Char.Vector_2D_Texture_Position SPC %ScriptObject_Char.Vector_2D_Size);

/***********************************************/
/*
%Sprite_Object=new Sprite()
{

Position=getRandom(-50,50) SPC getRandom(-50,50);
Size="5 5";
Image=%ScriptObject_Char.Image_Asset;
Frame=%ScriptObject_Char.Frame;

};

SandboxScene.add(%Sprite_Object);
*/
/***********************************************/

}

%FileObject_File.close();

/*****************************************************************/

//Load Katakana.

%this.Image_Asset_Object_Katakana=new ImageAsset()
{

ExplicitMode=true;

};

%this.Image_Asset_Object_Katakana.setImageFile("./Katakana_0.png");

%this.Image_Asset_ID_Katakana=AssetDatabase.addPrivateAsset(%this.Image_Asset_Object_Katakana);

/*****************************************************************/

%this.Simset_Map_Katakana=new SimSet();

%FileObject_File=new FileObject();

echo("openForRead():" SPC %FileObject_File.openForRead("./Katakana.fnt"));

//Get past first 4 lines.
for (%x=0;%x<4;%x++)
{

%String_Line=%FileObject_File.readLine();

}

%Int_Frame_Counter=0;

while (!%FileObject_File.isEOF())
{

%ScriptObject_Char=new ScriptObject()
{

ID_Unicode=0;

Vector_2D_Texture_Position="0 0";

Vector_2D_Size="0 0";

Frame=0;

};

%String_Line=%FileObject_File.readLine();

//echo("readLine():" SPC %String_Line);

%Int_Counter=1;

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"id=");

%ScriptObject_Char.ID_Unicode=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"x=");

%ScriptObject_Char.Vector_2D_Texture_Position.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"y=");

%ScriptObject_Char.Vector_2D_Texture_Position.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"width=");

%ScriptObject_Char.Vector_2D_Size.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"height=");

%ScriptObject_Char.Vector_2D_Size.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%ScriptObject_Char.Image_Asset=%this.Image_Asset_ID_Katakana;

%this.Image_Asset_Object_Katakana.addExplicitCell
(
%ScriptObject_Char.Vector_2D_Texture_Position.X,
%ScriptObject_Char.Vector_2D_Texture_Position.Y,
%ScriptObject_Char.Vector_2D_Size.X,
%ScriptObject_Char.Vector_2D_Size.Y
);

%ScriptObject_Char.Frame=%Int_Frame_Counter;

%Int_Frame_Counter++;

/***********************************************/

%this.Simset_Map_Katakana.add(%ScriptObject_Char);

//echo("Added" SPC %ScriptObject_Char.ID_Unicode SPC %ScriptObject_Char.Vector_2D_Texture_Position SPC %ScriptObject_Char.Vector_2D_Size);

/***********************************************/
/*
%Sprite_Object=new Sprite()
{

Position=getRandom(-50,50) SPC getRandom(-50,50);
Size="5 5";
Image=%ScriptObject_Char.Image_Asset;
Frame=%ScriptObject_Char.Frame;

};

SandboxScene.add(%Sprite_Object);
*/
}

%FileObject_File.close();

/*********************************************************************/

%FileObject_File=new FileObject();

echo("openForRead():" SPC %FileObject_File.openForRead("./Hiragana_Uni.txt"));

%Int_Index=0;

while (!%FileObject_File.isEOF())
{

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char=%this.Simset_Map_Hiragana.getObject(%Int_Index);

//Naughty to not declare Unicode_Character :>.
%ScriptObject_Char.Unicode_Character=%String_Line;

//echo(%ScriptObject_Char.Unicode_Character);

%Int_Index++;

}

%FileObject_File.close();

/*******************************************************/

%FileObject_File=new FileObject();

echo("openForRead():" SPC %FileObject_File.openForRead("./Katakana_Uni.txt"));

%Int_Index=0;

while (!%FileObject_File.isEOF())
{

%String_Line=%FileObject_File.readLine();

%ScriptObject_Char=%this.Simset_Map_Katakana.getObject(%Int_Index);

//Naughty to not declare Unicode_Character :>.
%ScriptObject_Char.Unicode_Character=%String_Line;

//echo(%ScriptObject_Char.Unicode_Character);

%Int_Index++;

}

%FileObject_File.close();

/*******************************************************/

//Don't load Kanji, shit's huge! It'll choke t2d.  You can load the bitmaps and the
//script objects but you have to add/clear the explicit cells in chunks.

return;

//Load Kanji.

%this.Image_Asset_Object_Kanji_0=new ImageAsset()
{

ExplicitMode=true;

};

%this.Image_Asset_Object_Kanji_0.setImageFile("./Kanji_0.png");

%this.Image_Asset_ID_Kanji_0=AssetDatabase.addPrivateAsset(%this.Image_Asset_Object_Kanji_0);

%Int_Frame_Counter_0=0;

/************************************/

%this.Image_Asset_Object_Kanji_1=new ImageAsset()
{

ExplicitMode=true;

};

%this.Image_Asset_Object_Kanji_1.setImageFile("./Kanji_1.png");

%this.Image_Asset_ID_Kanji_1=AssetDatabase.addPrivateAsset(%this.Image_Asset_Object_Kanji_1);

%Int_Frame_Counter_1=0;

/*************************************/

%this.Image_Asset_Object_Kanji_2=new ImageAsset()
{

ExplicitMode=true;

};

%this.Image_Asset_Object_Kanji_2.setImageFile("./Kanji_2.png");

%this.Image_Asset_ID_Kanji_2=AssetDatabase.addPrivateAsset(%this.Image_Asset_Object_Kanji_2);

%Int_Frame_Counter_2=0;

/*********************************************************************/

%this.Simset_Map_Kanji=new SimSet();

%FileObject_File=new FileObject();

echo("openForRead():" SPC %FileObject_File.openForRead("./Kanji.fnt"));

//Get past first 6 lines.
for (%x=0;%x<6;%x++)
{

%String_Line=%FileObject_File.readLine();

}

while (!%FileObject_File.isEOF())
{

%ScriptObject_Char=new ScriptObject()
{

ID_Unicode=0;

Vector_2D_Texture_Position="0 0";

Vector_2D_Size="0 0";

Frame=0;

};

%String_Line=%FileObject_File.readLine();

//echo("readLine():" SPC %String_Line);

%Int_Counter=1;

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"id=");

%ScriptObject_Char.ID_Unicode=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"x=");

%ScriptObject_Char.Vector_2D_Texture_Position.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"y=");

%ScriptObject_Char.Vector_2D_Texture_Position.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"width=");

%ScriptObject_Char.Vector_2D_Size.X=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$="")
{

%Word=stripChars(%Word,"height=");

%ScriptObject_Char.Vector_2D_Size.Y=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

%Word="";

%Bool_Break=false;

%Int_Page=0;

while (!%Bool_Break)
{

%Word=getWord(%String_Line,%Int_Counter);

if (%Word!$=""&&strstr(%Word,"page=")!=-1)
{

%Word=stripChars(%Word,"page=");

%Int_Page=%Word;

%Bool_Break=true;

}

%Int_Counter++;

}

/***********************************************/

if (%Int_Page==0)
{

%ScriptObject_Char.Image_Asset=%this.Image_Asset_ID_Kanji_0;

%this.Image_Asset_Object_Kanji_0.addExplicitCell
(
%ScriptObject_Char.Vector_2D_Texture_Position.X,
%ScriptObject_Char.Vector_2D_Texture_Position.Y,
%ScriptObject_Char.Vector_2D_Size.X,
%ScriptObject_Char.Vector_2D_Size.Y
);

%ScriptObject_Char.Frame=%Int_Frame_Counter_0;

%Int_Frame_Counter_0++;

}
else if (%Int_Page==1)
{

%ScriptObject_Char.Image_Asset=%this.Image_Asset_ID_Kanji_1;

%this.Image_Asset_Object_Kanji_1.addExplicitCell
(
%ScriptObject_Char.Vector_2D_Texture_Position.X,
%ScriptObject_Char.Vector_2D_Texture_Position.Y,
%ScriptObject_Char.Vector_2D_Size.X,
%ScriptObject_Char.Vector_2D_Size.Y
);

%ScriptObject_Char.Frame=%Int_Frame_Counter_1;

%Int_Frame_Counter_1++;

}
else if (%Int_Page==2)
{

%ScriptObject_Char.Image_Asset=%this.Image_Asset_ID_Kanji_2;

%this.Image_Asset_Object_Kanji_2.addExplicitCell
(
%ScriptObject_Char.Vector_2D_Texture_Position.X,
%ScriptObject_Char.Vector_2D_Texture_Position.Y,
%ScriptObject_Char.Vector_2D_Size.X,
%ScriptObject_Char.Vector_2D_Size.Y
);

%ScriptObject_Char.Frame=%Int_Frame_Counter_2;

%Int_Frame_Counter_2++;

}

/*************************/

%this.Simset_Map_Kanji.add(%ScriptObject_Char);

//echo("Added" SPC %ScriptObject_Char.ID_Unicode SPC %ScriptObject_Char.Vector_2D_Texture_Position SPC %ScriptObject_Char.Vector_2D_Size);

}

%FileObject_File.close();

}

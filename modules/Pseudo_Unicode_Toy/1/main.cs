//-----------------------------------------------------------------------------
// Copyright (c) 2013 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

exec("./Function_Load_Characters.cs");

exec("./Function_Load_Dictionary.cs");

function Pseudo_Unicode_Toy::create( %this )
{
    // Reset the toy.    
    Pseudo_Unicode_Toy.reset();
}

//-----------------------------------------------------------------------------

function Pseudo_Unicode_Toy::destroy( %this )
{
}

//-----------------------------------------------------------------------------

function Pseudo_Unicode_Toy::reset( %this )
{

SandboxScene.clear();
        
%this.Function_Load_Characters();

%this.Function_Load_Dictionary();

/*********************************************/

%ScriptObject_Char=%this.Simset_Dictionary.getObject(0);

echo(%ScriptObject_Char.String_Kanji_Or_Kana);

echo(%ScriptObject_Char.String_Kana);

echo(%ScriptObject_Char.String_Definition);

//%FileObject_Temp=new FileObject();

//%FileObject_Temp.openForWrite("./test.txt");

%Kana_Temp=0;

if (%ScriptObject_Char.String_Kana!$="")
{

%Kana_Temp=%ScriptObject_Char.String_Kana;

}
else
{

%Kana_Temp=%ScriptObject_Char.String_Kanji_Or_Kana;

}

echo("kana strlen" SPC strlen(%Kana_Temp));

for (%x=0;%x<strlen(%Kana_Temp);%x+=3)
{

%Individual_Char=getSubStr(%Kana_Temp,%x,3);

echo(%Individual_Char);

%Bool_Found_Hiragana=false;

%Kana_Char=0;

%Bool_Found_Katakana=false;

for (%y=0;%y<%this.Simset_Map_Hiragana.getCount();%y++)
{

%Kana_Char=%this.Simset_Map_Hiragana.getObject(%y);

if (%Kana_Char.Unicode_Character$=%Individual_Char)
{

%Bool_Found_Hiragana=true;

break;

}

}

if (!%Bool_Found_Hiragana)
{

for (%y=0;%y<%this.Simset_Map_Katakana.getCount();%y++)
{

%Kana_Char=%this.Simset_Map_Katakana.getObject(%y);

if (%Kana_Char.Unicode_Character$=%Individual_Char)
{

%Bool_Found_Katakana=true;

break;

}

}

}

%Sprite_Object=new Sprite()
{

Position=getRandom(-50,50) SPC getRandom(-50,50);
Size="5 5";
Image=%Kana_Char.Image_Asset;
Frame=%Kana_Char.Frame;

};

SandboxScene.add(%Sprite_Object);


//%FileObject_Temp.writeLine(getSubStr(%ScriptObject_Char.String_Kana,%x,3));

}

//%FileObject_Temp.close();

/*********************************************/

/*
%FileObject_Temp=new FileObject();

%FileObject_Temp.openForWrite("./Hiragana.txt");

for (%x=0;%x<%this.Simset_Map_Hiragana.getCount();%x++)
{

%ScriptObject_Character=%this.Simset_Map_Hiragana.getObject(%x);

%FileObject_Temp.writeLine(%ScriptObject_Character.ID_Unicode);

}

%FileObject_Temp.close();
*/

/*
%FileObject_Temp=new FileObject();

%FileObject_Temp.openForWrite("./Katakana.txt");

for (%x=0;%x<%this.Simset_Map_Hiragana.getCount();%x++)
{

%ScriptObject_Character=%this.Simset_Map_Katakana.getObject(%x);

%FileObject_Temp.writeLine(%ScriptObject_Character.ID_Unicode);

}

%FileObject_Temp.close();
*/

}

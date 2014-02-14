function Pseudo_Unicode_Toy::Function_Pronunciate(%this,%String_Kana)
{

for (%x=0;%x<strlen(%String_Kana);%x+=3)
{

%Individual_Char=getSubStr(%String_Kana,%x,3);

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

echo(%Kana_Char.Pronunciation);

//Sokuons: Hiragana: っ Katakana: ッ

if (%Kana_Char.Pronunciation$="っ"||%Kana_Char.Pronunciation$="ッ")
{

echo("found sokuon");

}//Youons
else if (%Kana_Char.Pronunciation$="ゃ"||%Kana_Char.Pronunciation$="ャ")//ya
{

echo("found ya");

}
else if (%Kana_Char.Pronunciation$="ゅ"||%Kana_Char.Pronunciation$="ュ")//yu
{

echo("found yu");

}
else if (%Kana_Char.Pronunciation$="ょ"||%Kana_Char.Pronunciation$="ョ")//yo
{

echo("found yo");

}

}

}

function Dots_and_Crits::Load_Player_Data(%this)
{

Module_Player_Class.Player_Data_Clear();

for (%x=0;%x<$Simset_Players_Information.getCount();%x++)
{

%Player_To_Load=$Simset_Players_Information.getObject(%x);

%Bool_Found_Sprite=false;

for (%y=0;%y<$Simset_ModuleID_Player_Sprites.getCount();%y++)
{

%Module_ID_Player_Sprite=$Simset_ModuleID_Player_Sprites.getObject(%y);

if (%Module_ID_Player_Sprite.String_Description$=%Player_To_Load.String_Player_Sprite_Description)
{

ModuleDatabase.LoadExplicit(%Module_ID_Player_Sprite.Module_ID_Player_Sprite);

%Module_ID_Player_Sprite.Module_ID_Player_Sprite.Player_Sprite_Load();

%Player_To_Load.Module_ID_Player_Sprite=%Module_ID_Player_Sprite.Module_ID_Player_Sprite;

if (%Player_To_Load.Is_Playing)
{

Module_Player_Class.Player_Data_Add(%Player_To_Load);

}

%Bool_Found_Sprite=true;

break;

}

}

if (!%Bool_Found_Sprite)
{

//Set random sprite.
%Module_ID_Player_Sprite=$Simset_ModuleID_Player_Sprites.getObject(getRandom(0,$Simset_ModuleID_Player_Sprites.getCount()-1));

ModuleDatabase.LoadExplicit(%Module_ID_Player_Sprite.Module_ID_Player_Sprite);

%Module_ID_Player_Sprite.Module_ID_Player_Sprite.Player_Sprite_Load();

%Player_To_Load.Module_ID_Player_Sprite=%Module_ID_Player_Sprite.Module_ID_Player_Sprite;

if (%Player_To_Load.Is_Playing)
{

Module_Player_Class.Player_Data_Add(%Player_To_Load);

}

}

}

}

function Module_Player_Class::Player_Data_Refresh(%this,%Player_Information)
{

for (%x=0;%x<%this.Simset_Player_Data.getCount();%x++)
{

%Player_Data=%this.Simset_Player_Data.getObject(%x);

if (%Player_Data.Game_Connection_Handle==%Player_Information.Game_Connection_Handle)
{

if (%Player_Data.String_Player_Sprite_Description!$=%Player_Information.String_Player_Sprite_Description)
{

%Bool_Found_Sprite=false;

for (%y=0;%y<$Simset_ModuleID_Player_Sprites.getCount();%y++)
{

%Module_ID_Player_Sprite=$Simset_ModuleID_Player_Sprites.getObject(%y);

if (%Module_ID_Player_Sprite.String_Description$=%Player_Data.String_Player_Sprite_Description)
{

ModuleDatabase.LoadExplicit(%Module_ID_Player_Sprite.Module_ID_Player_Sprite);

%Module_ID_Player_Sprite.Module_ID_Player_Sprite.Player_Sprite_Load();

%Player_Data.Module_ID_Player_Sprite=%Module_ID_Player_Sprite.Module_ID_Player_Sprite;

if (%Player_Data.Is_Playing)
{

//Delete old sprite.

%Sprite_Position=%Player_Data.Player_Sprite_Data.Composite_Sprite.Position;

%Player_Data.Player_Sprite_Data.Composite_Sprite.safeDelete();

for (%y=0;%y<%Player_Data.getDynamicFieldCount();%y++)
{

%Dynamic_Field=%Player_Data.getFieldValue(%Player_Data.getDynamicField(%y));

if (%Dynamic_Field.getClassName()$="Simset")
{

%Dynamic_Field.deleteObjects();
%Dynamic_Field.delete();

%y=0;

}

}

//Load new sprite.

%Player_Data.Player_Sprite_Data=%Player_Data.Module_ID_Player_Sprite.Player_Sprite_Spawn(%Script_Object_Player_Data.Game_Connection_Handle);

Scene_Dots_and_Crits.add(%Player_Data.Player_Sprite_Data.Composite_Sprite);

%Player_Data.Player_Sprite_Data.Composite_Sprite.Position=%Sprite_Position;

Scene_Dots_and_Crits.add(%Player_Data.Player_Sprite_Data.Scene_Object_Mount);

%Player_Data.Player_Sprite_Data.Scene_Object_Mount.mount(%Player_Data.Player_Sprite_Data.Composite_Sprite,"0 0",0,true,-1);

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

%Player_Data.Module_ID_Player_Sprite=%Module_ID_Player_Sprite.Module_ID_Player_Sprite;

if (%Player_Data.Is_Playing)
{

//Delete old sprite.

%Sprite_Position=%Player_Data.Player_Sprite_Data.Composite_Sprite.Position;

%Player_Data.Player_Sprite_Data.Composite_Sprite.safeDelete();

for (%y=0;%y<%Player_Data.getDynamicFieldCount();%y++)
{

%Dynamic_Field=%Player_Data.getFieldValue(%Player_Data.getDynamicField(%y));

if (%Dynamic_Field.getClassName()$="Simset")
{

%Dynamic_Field.deleteObjects();
%Dynamic_Field.delete();

%y=0;

}

}

//Load new sprite.

%Player_Data.Player_Sprite_Data=%Player_Data.Module_ID_Player_Sprite.Player_Sprite_Spawn(%Script_Object_Player_Data.Game_Connection_Handle);

Scene_Dots_and_Crits.add(%Player_Data.Player_Sprite_Data.Composite_Sprite);

%Player_Data.Player_Sprite_Data.Composite_Sprite.Position=%Sprite_Position;

Scene_Dots_and_Crits.add(%Player_Data.Player_Sprite_Data.Scene_Object_Mount);

%Player_Data.Player_Sprite_Data.Scene_Object_Mount.mount(%Player_Data.Player_Sprite_Data.Composite_Sprite,"0 0",0,true,-1);

}

}

}

break;

}

}

}

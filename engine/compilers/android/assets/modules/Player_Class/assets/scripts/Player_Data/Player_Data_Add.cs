function Module_Player_Class::Player_Data_Add(%this,%Player_Information)
{

%Script_Object_Player_Data=new ScriptObject()
{

Game_Connection_Handle=%Player_Information.Game_Connection_Handle;
Connector_Name=%Player_Information.Connector_Name;
String_Player_Sprite_Description=%Player_Information.String_Player_Sprite_Description;
Module_ID_Player_Sprite=%Player_Information.Module_ID_Player_Sprite;

};

%this.Simset_Player_Data.add(%Script_Object_Player_Data);

%Script_Object_Player_Data.Player_Sprite_Data=%Script_Object_Player_Data.Module_ID_Player_Sprite.Player_Sprite_Spawn(%Script_Object_Player_Data.Game_Connection_Handle);

Scene_Dots_and_Crits.add(%Script_Object_Player_Data.Player_Sprite_Data.Composite_Sprite);

Scene_Dots_and_Crits.add(%Script_Object_Player_Data.Player_Sprite_Data.Scene_Object_Mount);

%Script_Object_Player_Data.Player_Sprite_Data.Scene_Object_Mount.mount(%Script_Object_Player_Data.Player_Sprite_Data.Composite_Sprite,"0 0",0,true,-1);

$Module_ID_Map_Loaded.Player_Spawn(%Script_Object_Player_Data.Player_Sprite_Data.Composite_Sprite);

}

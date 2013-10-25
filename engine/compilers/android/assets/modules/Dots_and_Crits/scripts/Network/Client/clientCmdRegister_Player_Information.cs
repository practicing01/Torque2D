function clientCmdRegister_Player_Information(%Game_Connection_Handle,%Connector_Name,%String_Player_Sprite_Description)
{
echo("Registered Player Information:" SPC %Game_Connection_Handle SPC %Connector_Name SPC %String_Player_Sprite_Description);

for (%x=0;%x<$Simset_Players_Information.getCount();%x++)
{

%Player_Information=$Simset_Players_Information.getObject(%x);

if (%Player_Information.Game_Connection_Handle==%Game_Connection_Handle)
{

%Player_Information.Connector_Name=%Connector_Name;

%Player_Information.String_Player_Sprite_Description=%String_Player_Sprite_Description;

if ($Bool_Is_Playing&&%Player_Information.Is_Playing)
{

Module_Player_Class.Player_Data_Refresh(%Player_Information);

}

return;

}

}

%Script_Object=new ScriptObject()
{

Game_Connection_Handle=%Game_Connection_Handle;
Connector_Name=%Connector_Name;
String_Player_Sprite_Description=%String_Player_Sprite_Description;
Is_Playing=false;

};

$Simset_Players_Information.add(%Script_Object);

}

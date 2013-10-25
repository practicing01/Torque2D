function Module_Player_Class::Player_Data_Remove(%this,%Player)
{

for (%x=0;%x<%this.Simset_Player_Data.getCount();%x++)
{

%Player_Data=%this.Simset_Player_Data.getObject(%x);

if (%Player.Game_Connection_Handle==%Player_Data.Game_Connection_Handle)
{

%Player_Data.Player_Sprite_Data.Composite_Sprite.Module_ID_Parent.Player_Sprite_Data_Remove(%Player_Data.Script_Object_Parent);

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

%Player_Data.Player_Sprite_Data.delete();

}

}

}

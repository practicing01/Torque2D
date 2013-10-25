function Module_Player_Sprite_Ayn::Player_Sprite_Data_Remove(%this,%Script_Object_Player_Sprite)
{

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Object=%this.Simset_Player_Information.getObject(%x);

if (%Object==%Script_Object_Player_Sprite)
{

%this.Simset_Player_Information.remove(%Object);

break;

}

}

}

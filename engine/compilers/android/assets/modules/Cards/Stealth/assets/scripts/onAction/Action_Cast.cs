function Module_Card_Stealth::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=0;

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=%Player_Object;

break;

}

}

if (%Target_Player==0){return;}

//Use player info to play animations.

if (%Player_Sprite_Target_Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

if (%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteBlendAlpha()!=0.5)
{

%Target_Player.Player_Sprite_Data.Composite_Sprite.setSpriteBlendAlpha(0.5);

}
else
{

%Target_Player.Player_Sprite_Data.Composite_Sprite.setSpriteBlendAlpha(1.0);

}

}
else
{

if (%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteBlendAlpha()!=0)
{

%Target_Player.Player_Sprite_Data.Composite_Sprite.setSpriteBlendAlpha(0);

}
else
{

%Target_Player.Player_Sprite_Data.Composite_Sprite.setSpriteBlendAlpha(1);

}

}

}

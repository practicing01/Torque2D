function Module_Card_Scale::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle,%Vector_2D_Position)
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

%New_Size="0 0";

%New_Size.X=mAbs(%Target_Player.Player_Sprite_Data.Composite_Sprite.Position.X-%Vector_2D_Position.X);

%New_Size.Y=mAbs(%Target_Player.Player_Sprite_Data.Composite_Sprite.Position.Y-%Vector_2D_Position.Y);

%Target_Player.Player_Sprite_Data.Composite_Sprite.setSpriteSize(%New_Size);

%Target_Player.Player_Sprite_Data.Composite_Sprite.clearCollisionShapes();

%Target_Player.Player_Sprite_Data.Composite_Sprite.createPolygonBoxCollisionShape(%New_Size);

}

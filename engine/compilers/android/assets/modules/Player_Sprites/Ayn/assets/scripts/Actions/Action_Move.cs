function Module_Player_Sprite_Ayn::Action_Move(%this,%Player_Information,%Vector_2D_Position)
{

%Angle=(Vector2AngleToPoint(%Player_Information.Composite_Sprite.Position,%Vector_2D_Position)+180)%360;

if ((%Angle>=337.5&&%Angle<=360)||(%Angle>=0&&%Angle<22.5))//Left
{

%Player_Information.Vector_2D_Direction.X=-1;

%Player_Information.Vector_2D_Direction.Y=0;

%Player_Information.Scene_Object_Mount.setAngle(90);

}
else if ((%Angle>=22.5&&%Angle<67.5))//Down-Left
{

%Player_Information.Vector_2D_Direction.X=-1;

%Player_Information.Vector_2D_Direction.Y=-1;

%Player_Information.Scene_Object_Mount.setAngle(135);

}
else if ((%Angle>=67.5&&%Angle<112.5))//Down
{

%Player_Information.Vector_2D_Direction.X=0;

%Player_Information.Vector_2D_Direction.Y=-1;

%Player_Information.Scene_Object_Mount.setAngle(180);

}
else if ((%Angle>=112.5&&%Angle<157.5))//Down-Right
{

%Player_Information.Vector_2D_Direction.X=1;

%Player_Information.Vector_2D_Direction.Y=-1;

%Player_Information.Scene_Object_Mount.setAngle(225);

}
else if ((%Angle>=157.5&&%Angle<202.5))//Right
{

%Player_Information.Vector_2D_Direction.X=1;

%Player_Information.Vector_2D_Direction.Y=0;

%Player_Information.Scene_Object_Mount.setAngle(270);

}
else if ((%Angle>=202.5&&%Angle<247.5))//Up-Right
{

%Player_Information.Vector_2D_Direction.X=1;

%Player_Information.Vector_2D_Direction.Y=1;

%Player_Information.Scene_Object_Mount.setAngle(315);

}
else if ((%Angle>=247.5&&%Angle<292.5))//Up
{

%Player_Information.Vector_2D_Direction.X=0;

%Player_Information.Vector_2D_Direction.Y=1;

%Player_Information.Scene_Object_Mount.setAngle(0);

}
else if ((%Angle>=292.5&&%Angle<337.5))//Up-Left
{

%Player_Information.Vector_2D_Direction.X=-1;

%Player_Information.Vector_2D_Direction.Y=1;

%Player_Information.Scene_Object_Mount.setAngle(45);

}

if (%Player_Information.Vector_2D_Direction.X==0&&%Player_Information.Vector_2D_Direction.Y==0)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==0)
{

if (%Player_Information.Vector_2D_Direction.X==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==0)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Up.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Down.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else
{

if (%Player_Information.Vector_2D_Direction.X==1)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Up_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Down_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

if (%Player_Information.Vector_2D_Direction.Y==1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Up_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Run_Down_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Run_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

/*******************************************/

%Player_Information.Bool_Is_Mobile=true;

if (%Player_Information.Current_Speed>0)
{

%Player_Information.Composite_Sprite.moveTo(%Vector_2D_Position,%Player_Information.Current_Speed,true,false);

}
else
{

%this.onMoveToComplete(%Player_Information.Composite_Sprite);

}

}

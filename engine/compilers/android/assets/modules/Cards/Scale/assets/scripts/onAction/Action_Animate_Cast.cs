function Module_Card_Scale::Action_Animate_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=0;

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=%Player_Object.Player_Sprite_Data;

break;

}

}

if (%Target_Player==0){return;}

if (%Target_Player.Bool_Is_Mobile)
{

if (%Target_Player.Vector_2D_Direction.X==0&&%Target_Player.Vector_2D_Direction.Y==0)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Run_Cast_Self_Down.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Run_Cast_Self_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.Y==0)
{

if (%Target_Player.Vector_2D_Direction.X==1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Run_Cast_Self_Right.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Run_Cast_Self_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.X==-1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Run_Cast_Self_Left.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Run_Cast_Self_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Target_Player.Vector_2D_Direction.X==0)
{

if (%Target_Player.Vector_2D_Direction.Y==1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Run_Cast_Self_Up.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Run_Cast_Self_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.Y==-1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Run_Cast_Self_Down.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Run_Cast_Self_Down.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else
{

if (%Target_Player.Vector_2D_Direction.X==1)
{

if (%Target_Player.Vector_2D_Direction.Y==1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Run_Cast_Self_Up_Right.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Run_Cast_Self_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.Y==-1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Run_Cast_Self_Down_Right.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Run_Cast_Self_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Target_Player.Vector_2D_Direction.X==-1)
{

if (%Target_Player.Vector_2D_Direction.Y==1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Run_Cast_Self_Up_Left.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Run_Cast_Self_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.Y==-1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Run_Cast_Self_Down_Left.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Run_Cast_Self_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}
else
{

if (%Target_Player.Vector_2D_Direction.X==0&&%Target_Player.Vector_2D_Direction.Y==0)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Stand_Cast_Self_Down.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Stand_Cast_Self_Down.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.Y==0)
{

if (%Target_Player.Vector_2D_Direction.X==1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Stand_Cast_Self_Right.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Stand_Cast_Self_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.X==-1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Stand_Cast_Self_Left.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Stand_Cast_Self_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Target_Player.Vector_2D_Direction.X==0)
{

if (%Target_Player.Vector_2D_Direction.Y==1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Stand_Cast_Self_Up.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Stand_Cast_Self_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.Y==-1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Stand_Cast_Self_Down.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Stand_Cast_Self_Down.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else
{

if (%Target_Player.Vector_2D_Direction.X==1)
{

if (%Target_Player.Vector_2D_Direction.Y==1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Stand_Cast_Self_Up_Right.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Stand_Cast_Self_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.Y==-1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Stand_Cast_Self_Down_Right.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Stand_Cast_Self_Down_Right.getCount()-1)
)
.Asset_ID_Animation
);

}

}
else if (%Target_Player.Vector_2D_Direction.X==-1)
{

if (%Target_Player.Vector_2D_Direction.Y==1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Stand_Cast_Self_Up_Left.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Stand_Cast_Self_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Target_Player.Vector_2D_Direction.Y==-1)
{

%Target_Player.Composite_Sprite.setSpriteAnimation
(
%Target_Player.Simset_Animation_Stand_Cast_Self_Down_Left.getObject
(
getRandom(0,%Target_Player.Simset_Animation_Stand_Cast_Self_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}

//Schedule animation reset.

cancel(%Player_Information.Schedule_Animation_Reset);

%Player_Information.Schedule_Animation_Reset=schedule(2000,0,%Player_Information.Module_ID_Parent@"::Animation_Reset",%Player_Information.Module_ID_Parent,%Player_Information);

}

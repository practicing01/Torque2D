function Module_Player_Sprite_Ayn::onMoveToComplete(%this,%Composite_Sprite_Player)
{

%Player_Information=%Composite_Sprite_Player.Script_Object_Parent;

%Player_Information.Bool_Is_Mobile=false;

if (%Player_Information.Vector_2D_Direction.X==0&&%Player_Information.Vector_2D_Direction.Y==0)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Down.getCount()-1)
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
%Player_Information.Simset_Animation_Stand_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.X==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Left.getCount()-1)
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
%Player_Information.Simset_Animation_Stand_Up.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Up.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Down.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Down.getCount()-1)
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
%Player_Information.Simset_Animation_Stand_Up_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Up_Right.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Down_Right.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Down_Right.getCount()-1)
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
%Player_Information.Simset_Animation_Stand_Up_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Up_Left.getCount()-1)
)
.Asset_ID_Animation
);

}
else if (%Player_Information.Vector_2D_Direction.Y==-1)
{

%Player_Information.Composite_Sprite.setSpriteAnimation
(
%Player_Information.Simset_Animation_Stand_Down_Left.getObject
(
getRandom(0,%Player_Information.Simset_Animation_Stand_Down_Left.getCount()-1)
)
.Asset_ID_Animation
);

}

}

}

}

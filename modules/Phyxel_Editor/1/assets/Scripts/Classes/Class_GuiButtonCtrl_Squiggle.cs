function Class_GuiButtonCtrl_Squiggle::onAction(%this)
{

%this.Module_ID_Parent.Bool_Squiggle=!%this.Module_ID_Parent.Bool_Squiggle;

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Grid_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.Module_ID_Parent.SimSet_Grid_Phyxels.getObject(%x);

if (%this.Module_ID_Parent.Bool_Squiggle)
{

if (%Sprite_Phyxel.Bool_Is_Phyxel&&%Sprite_Phyxel.Bool_Is_Squiggler)
{

%Sprite_Phyxel.setCollisionShapeIsSensor(0,false);

%Sprite_Phyxel.Schedule_Squiggle=schedule(0,0,"Class_Phyxel::Squiggle",%Sprite_Phyxel);

}
else if (!%Sprite_Phyxel.Bool_Is_Phyxel)
{

%Sprite_Phyxel.Active=false;

%Sprite_Phyxel.Visible=false;

}

}
else
{

%Sprite_Phyxel.setCollisionShapeIsSensor(0,true);

cancel(%Sprite_Phyxel.Schedule_Squiggle);

%Sprite_Phyxel.setAngularVelocity(0);

%Sprite_Phyxel.setLinearVelocity("0 0");

%Sprite_Phyxel.Angle=0;

%Sprite_Phyxel.Position=%Sprite_Phyxel.Vector_2D_Origin;

%Sprite_Phyxel.Active=true;

%Sprite_Phyxel.Visible=true;

}

}

}

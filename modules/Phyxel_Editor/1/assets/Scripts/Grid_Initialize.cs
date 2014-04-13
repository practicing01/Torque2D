function Phyxel_Editor::Grid_Initialize( %this )
{

%this.SimSet_Grid_Phyxels=new SimSet();

%this.Vector_2D_Phyxel_Size=Vector_2D_Vector_To_Camera_By_Resolution_Scale("15 15","800 600");

for (%y=0;%y<%this.Vector_2D_Grid_Size.Y;%y++)
{

for (%x=0;%x<%this.Vector_2D_Grid_Size.X;%x++)
{

%Vector_2D_Position=%x SPC %y;

%Vector_2D_Position.X*=%this.Vector_2D_Phyxel_Size.X;

%Vector_2D_Position.Y*=%this.Vector_2D_Phyxel_Size.Y;

%Vector_2D_Position.X-=(%this.Vector_2D_Grid_Size.X/2)*%this.Vector_2D_Phyxel_Size.X;

%Vector_2D_Position.Y-=(%this.Vector_2D_Grid_Size.Y/2)*%this.Vector_2D_Phyxel_Size.Y;

%Sprite_Phyxel=new sprite()
{

Position=%Vector_2D_Position;

Size=%this.Vector_2D_Phyxel_Size;

Image="ToyAssets:Blank";

Bool_Is_Phyxel=false;

Bool_Is_Squiggler=false;

Vector_2D_Origin=%Vector_2D_Position;

Vector_2D_Original_Size=%this.Vector_2D_Phyxel_Size;

Schedule_Squiggle=0;

class="Class_Phyxel";

SceneLayer=17;

SceneGroup=0;

DefaultDensity=0;

DefaultRestitution=1;

SimSet_Distance_Joint_Connections=0;

SimSet_Weld_Joint_Connections=0;

Vector_2D_Grid_Position=%x SPC %y;

};

%Sprite_Phyxel.SimSet_Distance_Joint_Connections=new SimSet();

%Sprite_Phyxel.SimSet_Weld_Joint_Connections=new SimSet();

%Sprite_Phyxel.setCollisionGroups(0);

%Int_Collision_Shape_Index=%Sprite_Phyxel.createPolygonBoxCollisionShape(%Sprite_Phyxel.Size);

%Sprite_Phyxel.setCollisionShapeIsSensor(%Int_Collision_Shape_Index,true);

SandboxScene.add(%Sprite_Phyxel);

%this.SimSet_Grid_Phyxels.add(%Sprite_Phyxel);

}

}

}


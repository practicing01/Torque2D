function USA_Comet_Shark::Create_Shark(%this)
{

%Ass=AssetDatabase.acquireAsset("USA_Comet_Shark:Image_USS_Shark");

%Float_Size="0 0";

if (%Ass.getCellWidth()==0)
{

%Float_Size=%Ass.getImageSize();

}
else
{

%Float_Size.X=%Ass.getCellWidth();

%Float_Size.Y=%Ass.getCellHeight();

}

%Float_Size=Vector2Mult(%Float_Size,SandboxWindow.getCameraWorldScale());

%Float_Size=Vector2Mult(%Float_Size,"4 4");

%this.Sprite_Shark=new Sprite()
{

Position="0 0";

Angle=-90;

LinearDamping=0.1;

Image="USA_Comet_Shark:Image_USS_Shark";

Size=%Float_Size;

SceneGroup=2;

CollisionCallback=true;

class="Class_Shark";

Collision_Shape_Index=-1;

};

%this.Sprite_Shark.Collision_Shape_Index=%this.Sprite_Shark.createPolygonBoxCollisionShape(%this.Sprite_Shark.Size);

%this.Sprite_Shark.setCollisionShapeIsSensor(%this.Sprite_Shark.Collision_Shape_Index,true);

SandboxScene.add(%this.Sprite_Shark);

SandboxWindow.mount(%this.Sprite_Shark);

}

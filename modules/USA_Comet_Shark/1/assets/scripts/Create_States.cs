function USA_Comet_Shark::Create_States(%this)
{

if (isObject(%this.SimSet_States_Remaining))
{

%this.SimSet_States_Remaining.deleteObjects();

}
else
{

%this.SimSet_States_Remaining=new SimSet();

}

if (!isObject(%this.SimSet_Positions))
{

%this.SimSet_Positions=new SimSet();

for (%y=0;%y<50;%y++)
{

for (%x=0;%x<50;%x++)
{

%ScriptObject_Position=new ScriptObject()
{

Vector_2D_Position=%x*256 SPC %y*256;

};

%this.SimSet_Positions.add(%ScriptObject_Position);

%ScriptObject_Position.Vector_2D_Position=Vector2Sub(%ScriptObject_Position.Vector_2D_Position,"6400 6400");

%ScriptObject_Position.Vector_2D_Position=Vector2Add(%ScriptObject_Position.Vector_2D_Position,"128 128");

%ScriptObject_Position.Vector_2D_Position=Vector2Mult(%ScriptObject_Position.Vector_2D_Position,SandboxWindow.getCameraWorldScale());

}

}

}

%SimSet_Temp_State=new SimSet();

%SimSet_Temp_Position=new SimSet();

for (%x=0;%x<50;%x++)
{

%ScriptObject_State=%this.SimSet_States.getObject(getRandom(0,%this.SimSet_States.getCount()-1));

%SimSet_Temp_State.add(%ScriptObject_State);

%this.SimSet_States.remove(%ScriptObject_State);

%ScriptObject_Position=%this.SimSet_Positions.getObject(getRandom(0,%this.SimSet_Positions.getCount()-1));

%SimSet_Temp_Position.add(%ScriptObject_Position);

%this.SimSet_Positions.remove(%ScriptObject_Position);

%Ass=AssetDatabase.acquireAsset(%ScriptObject_State.String_AssetName);

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

%Color=getRandomF(0.5,1) SPC getRandomF(0.5,1) SPC getRandomF(0.5,1) SPC getRandomF(0.5,1);

%Sprite_State=new Sprite()
{

BodyType="static";

Position=%ScriptObject_Position.Vector_2D_Position;

Image=%ScriptObject_State.String_AssetName;

Size=%Float_Size;

SceneGroup=1;

CollisionCallback=true;

class="Class_State";

Collision_Shape_Index=-1;

BlendColor=%Color;

ScriptObject_State=0;

};

%Sprite_State.Collision_Shape_Index=%Sprite_State.createPolygonBoxCollisionShape(%Sprite_State.Size);

%Sprite_State.setCollisionShapeIsSensor(%Sprite_State.Collision_Shape_Index,true);

SandboxScene.add(%Sprite_State);

%ScriptObject_State=new ScriptObject()
{

String_State=strreplace(%ScriptObject_State.String_AssetName,"USA_Comet_Shark:Image_","");

};

%this.SimSet_States_Remaining.add(%ScriptObject_State);

%Sprite_State.ScriptObject_State=%ScriptObject_State;

}

%this.SimSet_States.delete();

%this.SimSet_States=%SimSet_Temp_State;

for (%x=0;%x<%SimSet_Temp_Position.getCount();%x++)
{

%ScriptObject_Position=%SimSet_Temp_Position.getObject(%x);

%this.SimSet_Positions.add(%ScriptObject_Position);

%SimSet_Temp_Position.remove(%ScriptObject_Position);

%x=-1;

}

}

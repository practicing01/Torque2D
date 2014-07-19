function Class_Shark::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_State")
{

%String_Image="USA_Comet_Shark:Image_X";

if (strreplace(%Colliding_Object.Image,"USA_Comet_Shark:Image_","")$=USA_Comet_Shark.Gui_Target_State.text)
{

%String_Image="USA_Comet_Shark:Image_Check";

}

%Ass=AssetDatabase.acquireAsset(%String_Image);

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

%Sprite_Mark=new Sprite()
{

Position=%Colliding_Object.Position;

Image=%String_Image;

Size=%Float_Size;

LifeTime=1;

};

SandboxScene.add(%Sprite_Mark);

USA_Comet_Shark.SimSet_States_Remaining.remove(%Colliding_Object.ScriptObject_State);

%Colliding_Object.safeDelete();

USA_Comet_Shark.Generate_Target_State();

}

}

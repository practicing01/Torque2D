function CompositeSprite_Tool::Initialize_CompositeSprite(%this)
{

%this.CompositeSprite_Level=new CompositeSprite()
{

SceneLayer=1;

BodyType="static";

PickingAllowed=false;

Position="0 0";

};

%this.CompositeSprite_Level.SetBatchLayout("off");

%this.CompositeSprite_Level.SetBatchSortMode("z");

%this.CompositeSprite_Level.SetBatchIsolated(true);

SandboxScene.add(%this.CompositeSprite_Level);

}

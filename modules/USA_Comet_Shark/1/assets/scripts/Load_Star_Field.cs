function USA_Comet_Shark::Load_Star_Field(%this)
{

%CompositeSprite_Object=TamlRead("./../CompositeSprites/Star_Field.taml");

%CompositeSprite_Object.SceneLayer=1;

SandboxScene.add(%CompositeSprite_Object);

}

function CompositeSprite_Tool::Add_Background(%this)
{

%CompositeSprite_Object=TamlRead("./../saved_CompositeSprites/"@%this.String_Filename@".taml");

if (!isObject(%CompositeSprite_Object)){return;}

%this.SimSet_Backgrounds.add(%CompositeSprite_Object);

%CompositeSprite_Object.SceneLayer=30;

%CompositeSprite_Object.setSceneLayerDepth(%this.SimSet_Backgrounds.getCount()-1);

SandboxScene.add(%CompositeSprite_Object);

}

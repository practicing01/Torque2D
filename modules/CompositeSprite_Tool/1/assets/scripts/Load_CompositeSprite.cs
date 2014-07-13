function CompositeSprite_Tool::Load_CompositeSprite(%this)
{

%CompositeSprite_Object=TamlRead("./../CompositeSprites/"@%this.String_Filename@".taml");

if (!isObject(%CompositeSprite_Object)){return;}

if (isObject(%this.CompositeSprite_Level))
{

%this.CompositeSprite_Level.safeDelete();

}

%this.CompositeSprite_Level=%CompositeSprite_Object;

SandboxScene.add(%this.CompositeSprite_Level);

}

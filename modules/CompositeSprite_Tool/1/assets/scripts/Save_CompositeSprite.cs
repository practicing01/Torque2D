function CompositeSprite_Tool::Save_CompositeSprite(%this)
{

TamlWrite(%this.CompositeSprite_Level,"./../CompositeSprites/"@%this.String_Filename@".taml");

}

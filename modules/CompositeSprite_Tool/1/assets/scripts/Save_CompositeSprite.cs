function CompositeSprite_Tool::Save_CompositeSprite(%this)
{

TamlWrite(%this.CompositeSprite_Level,"./../saved_CompositeSprites/"@%this.String_Filename@".taml");

}

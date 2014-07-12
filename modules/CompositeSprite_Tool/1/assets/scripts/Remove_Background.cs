function CompositeSprite_Tool::Remove_Background(%this)
{

if (!%this.SimSet_Backgrounds.getCount()){return;}

%CompositeSprite_Object=%this.SimSet_Backgrounds.getObject(%this.SimSet_Backgrounds.getCount()-1);

%CompositeSprite_Object.safeDelete();

}

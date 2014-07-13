function Class_CompositeSprite_Tool_GuiListBoxCtrl::onSelect(%this)
{

if (CompositeSprite_Tool.Highlighted_Object!=0)
{

if (CompositeSprite_Tool.CompositeSprite_Level.selectSpriteId(CompositeSprite_Tool.Highlighted_Object))
{

CompositeSprite_Tool.CompositeSprite_Level.setSpriteBlendColor(CompositeSprite_Tool.Highlighted_Object_BlendColor);

}

}

%SpriteID=CompositeSprite_Tool.SimSet_Picked_Object_List.getObject(%this.getSelectedItem()).SpriteID;

CompositeSprite_Tool.Highlighted_Object=%SpriteID;

if (CompositeSprite_Tool.CompositeSprite_Level.selectSpriteId(CompositeSprite_Tool.Highlighted_Object))
{

CompositeSprite_Tool.Highlighted_Object_BlendColor=CompositeSprite_Tool.CompositeSprite_Level.getSpriteBlendColor();

CompositeSprite_Tool.CompositeSprite_Level.setSpriteBlendColor("0.5 1.0 1.0 1.0");

}

}

function Class_CompositeSprite_Tool_GuiListBoxCtrl::onDoubleClick(%this)
{

if (CompositeSprite_Tool.CompositeSprite_Level.selectSpriteId(CompositeSprite_Tool.Highlighted_Object))
{

CompositeSprite_Tool.CompositeSprite_Level.removeSprite();

CompositeSprite_Tool.Highlighted_Object=0;

}

SandboxWindow.remove(CompositeSprite_Tool.GuiControl_Object_List);

}

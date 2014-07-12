function Class_CompositeSprite_Tool_GuiCheckBoxCtrl::onAction(%this)
{

if (%this.String_Type$="Grid_Visible")
{

CompositeSprite_Tool.CompositeSprite_Grid.Visible=!CompositeSprite_Tool.CompositeSprite_Grid.Visible;

}
else if (%this.String_Type$="Grid_Snap")
{

CompositeSprite_Tool.Bool_Grid_Snap=!CompositeSprite_Tool.Bool_Grid_Snap;

}

}

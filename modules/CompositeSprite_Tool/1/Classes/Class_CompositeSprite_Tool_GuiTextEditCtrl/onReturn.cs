function Class_CompositeSprite_Tool_GuiTextEditCtrl::onReturn(%this)
{

if (%this.String_Type$="Filename")
{

CompositeSprite_Tool.String_Filename=%this.getText();

}
else if (%this.String_Type$="CompositeSprite_Size")
{

CompositeSprite_Tool.CompositeSprite_Size=%this.getText();

CompositeSprite_Tool.Initialize_Grid();

}
else if (%this.String_Type$="Tile_Size")
{

CompositeSprite_Tool.Tile_Size=%this.getText();

}
else if (%this.String_Type$="Tile_Depth")
{

CompositeSprite_Tool.Tile_Depth=%this.getText();

}
else if (%this.String_Type$="Tile_Animation")
{

CompositeSprite_Tool.String_Tile_Animation=%this.getText();

}
else if (%this.String_Type$="Tile_Frame")
{

CompositeSprite_Tool.Tile_Frame=%this.getText();

}
else if (%this.String_Type$="Grid_Unit_Size")
{

CompositeSprite_Tool.Grid_Unit_Size=%this.getText();

CompositeSprite_Tool.Initialize_Grid();

}
else if (%this.String_Type$="Camera_Zoom")
{

CompositeSprite_Tool.Camera_Zoom=%this.getText();

}
else if (%this.String_Type$="Camera_Move_Units")
{

CompositeSprite_Tool.Camera_Move_Units=%this.getText();

}

}

function Class_CompositeSprite_Tool_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

if (CompositeSprite_Tool.Bool_Deleting)
{

CompositeSprite_Tool.Pick_For_Deletion(%Vector_2D_World_Position);

return;

}

CompositeSprite_Tool.Add_Sprite(%Vector_2D_World_Position);

%this.Vector_2D_Previous_Position=%Vector_2D_World_Position;

}

function Class_CompositeSprite_Tool_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{



}

function Class_CompositeSprite_Tool_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{

if (CompositeSprite_Tool.Bool_Deleting)
{

return;

}

%Vector_2D_Scaled_Tile_Size=Vector2Mult(CompositeSprite_Tool.Tile_Size,CompositeSprite_Tool.Camera_World_Scale);

if (Vector2Distance(%this.Vector_2D_Previous_Position,%Vector_2D_World_Position)>=%Vector_2D_Scaled_Tile_Size)
{

CompositeSprite_Tool.Add_Sprite(%Vector_2D_World_Position);

%this.Vector_2D_Previous_Position=%Vector_2D_World_Position;

}

}

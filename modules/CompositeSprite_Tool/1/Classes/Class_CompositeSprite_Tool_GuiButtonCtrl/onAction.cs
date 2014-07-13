function Class_CompositeSprite_Tool_GuiButtonCtrl::onAction(%this)
{

if (%this.String_Type$="Ass")
{

CompositeSprite_Tool.String_Selected_Image=%this->GuiSpriteCtrl_Ass.Image;

}
else if (%this.String_Type$="Save")
{

CompositeSprite_Tool.Save_CompositeSprite();

}
else if (%this.String_Type$="Load")
{

CompositeSprite_Tool.Load_CompositeSprite();

}
else if (%this.String_Type$="Add_Background")
{

CompositeSprite_Tool.Add_Background();

}
else if (%this.String_Type$="Remove_Background")
{

CompositeSprite_Tool.Remove_Background();

}
else if (%this.String_Type$="Delete")
{

CompositeSprite_Tool.Bool_Deleting=!CompositeSprite_Tool.Bool_Deleting;

}
else if (%this.String_Type$="ULeft")
{

CompositeSprite_Tool.Bool_Moving_Camera=!CompositeSprite_Tool.Bool_Moving_Camera;

if (!CompositeSprite_Tool.Bool_Moving_Camera)
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity("0 0");

}
else
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity(-CompositeSprite_Tool.Camera_Move_Units SPC CompositeSprite_Tool.Camera_Move_Units);

}

}
else if (%this.String_Type$="Up")
{

CompositeSprite_Tool.Bool_Moving_Camera=!CompositeSprite_Tool.Bool_Moving_Camera;

if (!CompositeSprite_Tool.Bool_Moving_Camera)
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity("0 0");

}
else
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity(0 SPC CompositeSprite_Tool.Camera_Move_Units);

}

}
else if (%this.String_Type$="URight")
{

CompositeSprite_Tool.Bool_Moving_Camera=!CompositeSprite_Tool.Bool_Moving_Camera;

if (!CompositeSprite_Tool.Bool_Moving_Camera)
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity("0 0");

}
else
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity(CompositeSprite_Tool.Camera_Move_Units SPC CompositeSprite_Tool.Camera_Move_Units);

}

}
else if (%this.String_Type$="Left")
{

CompositeSprite_Tool.Bool_Moving_Camera=!CompositeSprite_Tool.Bool_Moving_Camera;

if (!CompositeSprite_Tool.Bool_Moving_Camera)
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity("0 0");

}
else
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity(-CompositeSprite_Tool.Camera_Move_Units SPC 0);

}

}
else if (%this.String_Type$="Right")
{

CompositeSprite_Tool.Bool_Moving_Camera=!CompositeSprite_Tool.Bool_Moving_Camera;

if (!CompositeSprite_Tool.Bool_Moving_Camera)
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity("0 0");

}
else
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity(CompositeSprite_Tool.Camera_Move_Units SPC 0);

}

}
else if (%this.String_Type$="DLeft")
{

CompositeSprite_Tool.Bool_Moving_Camera=!CompositeSprite_Tool.Bool_Moving_Camera;

if (!CompositeSprite_Tool.Bool_Moving_Camera)
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity("0 0");

}
else
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity(-CompositeSprite_Tool.Camera_Move_Units SPC -CompositeSprite_Tool.Camera_Move_Units);

}

}
else if (%this.String_Type$="Down")
{

CompositeSprite_Tool.Bool_Moving_Camera=!CompositeSprite_Tool.Bool_Moving_Camera;

if (!CompositeSprite_Tool.Bool_Moving_Camera)
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity("0 0");

}
else
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity(0 SPC -CompositeSprite_Tool.Camera_Move_Units);

}

}
else if (%this.String_Type$="DRight")
{

CompositeSprite_Tool.Bool_Moving_Camera=!CompositeSprite_Tool.Bool_Moving_Camera;

if (!CompositeSprite_Tool.Bool_Moving_Camera)
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity("0 0");

}
else
{

CompositeSprite_Tool.SceneObject_Camera.setLinearVelocity(CompositeSprite_Tool.Camera_Move_Units SPC -CompositeSprite_Tool.Camera_Move_Units);

}

}

}

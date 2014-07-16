function Class_USA_Comet_Shark_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

%Float_Angle=Vector2AngleToPoint(USA_Comet_Shark.Sprite_Shark.Position,%Vector_2D_World_Position);

USA_Comet_Shark.Sprite_Shark.Angle=%Float_Angle;

USA_Comet_Shark.Sprite_Shark.setLinearVelocityPolar(%Float_Angle,20);

}

function Class_USA_Comet_Shark_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{

%Float_Angle=Vector2AngleToPoint(USA_Comet_Shark.Sprite_Shark.Position,%Vector_2D_World_Position);

USA_Comet_Shark.Sprite_Shark.Angle=%Float_Angle;

USA_Comet_Shark.Sprite_Shark.setLinearVelocityPolar(%Float_Angle,20);

}

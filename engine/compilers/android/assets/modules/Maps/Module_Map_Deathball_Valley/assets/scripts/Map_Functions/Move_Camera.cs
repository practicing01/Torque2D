function Module_Map_Deathball_Valley::Move_Camera(%this)
{

%Camera_Position=Window_Dots_and_Crits.getCameraPosition();

if (%this.Camera_Move_Schedule.Direction$="Up")
{

%Camera_Position.Y++;

}
else if (%this.Camera_Move_Schedule.Direction$="Down")
{

%Camera_Position.Y--;

}
else if (%this.Camera_Move_Schedule.Direction$="Left")
{

%Camera_Position.X--;

}
else if (%this.Camera_Move_Schedule.Direction$="Right")
{

%Camera_Position.X++;

}

Window_Dots_and_Crits.setCameraPosition(%Camera_Position);


%this.Camera_Move_Schedule.Schedule_Handle=schedule(25,0,"Module_Map_Deathball_Valley::Move_Camera",%this);

}

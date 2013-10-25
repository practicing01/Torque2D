function Module_Map_Deathball_Valley::Schedule_Camera_Move(%this,%Direction)
{

if (%this.Camera_Move_Schedule.Direction$=%Direction&&%this.Camera_Move_Schedule.Schedule_Handle!=0)
{

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

%this.Camera_Move_Schedule.Schedule_Handle=0;

}
else
{

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

%this.Camera_Move_Schedule.Direction=%Direction;

%this.Camera_Move_Schedule.Schedule_Handle=schedule(25,0,"Module_Map_Deathball_Valley::Move_Camera",%this);

}

}

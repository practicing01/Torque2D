function Module_Map_Deathball_Valley::Scene_Unload(%this)
{

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

%this.Ass_Unload();

}

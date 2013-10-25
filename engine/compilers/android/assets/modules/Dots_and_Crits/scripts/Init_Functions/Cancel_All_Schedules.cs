function Cancel_All_Schedules()
{

for (%x=0;%x<$Simset_Cancelable_Schedules_Global.getCount();%x++)
{

cancel($Simset_Cancelable_Schedules_Global.getObject(%x).Handle_Schedule);

}

$Simset_Cancelable_Schedules_Global.deleteObjects();

for (%x=0;%x<$Simset_Cancelable_Schedules_Skills.getCount();%x++)
{

cancel($Simset_Cancelable_Schedules_Skills.getObject(%x).Handle_Schedule);

}

$Simset_Cancelable_Schedules_Skills.deleteObjects();

}

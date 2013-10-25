function Module_Card_Heal::Relay_Module_Function(%this,%Client,%Module_Function,
%Parameter_0,%Parameter_1,%Parameter_2,%Parameter_3,%Parameter_4,%Parameter_5,%Parameter_6,
%Parameter_7,%Parameter_8,%Parameter_9,%Parameter_10,%Parameter_11,%Parameter_12)
{

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Information=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Information.Game_Connection_Handle==%Client)
{

if (%Module_Function$="Action_Animate_Cast")
{

%this.Action_Animate_Cast(%Player_Information,%Parameter_0);

}
else if (%Module_Function$="Action_Cast")
{

%this.Action_Cast(%Player_Information,%Parameter_0,%Parameter_1);

}

break;

}

}

}

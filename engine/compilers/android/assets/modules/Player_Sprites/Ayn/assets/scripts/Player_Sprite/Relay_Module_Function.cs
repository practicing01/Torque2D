function Module_Player_Sprite_Ayn::Relay_Module_Function(%this,%Client,%Module_Function,
%Parameter_0,%Parameter_1,%Parameter_2,%Parameter_3,%Parameter_4,%Parameter_5,%Parameter_6,
%Parameter_7,%Parameter_8,%Parameter_9,%Parameter_10,%Parameter_11,%Parameter_12)
{

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Information=%this.Simset_Player_Information.getObject(%x);

if (%Player_Information.Game_Connection_Handle==%Client)
{

if (%Module_Function$="Action_Move")
{

%this.Action_Move(%Player_Information,%Parameter_0);

}
else if (%Module_Function$="Action_Emote")
{

%this.Action_Emote(%Player_Information,%Parameter_0);

}
else if (%Module_Function$="Action_Attack")
{

%this.Action_Attack(%Player_Information,%Parameter_0,%Parameter_1);

}
else if (%Module_Function$="Action_Update_Health")
{

%this.Action_Update_Health(%Player_Information,%Parameter_0);

}
else if (%Module_Function$="Action_Position")
{

%this.Action_Position(%Player_Information,%Parameter_0);

}

break;

}

}

}

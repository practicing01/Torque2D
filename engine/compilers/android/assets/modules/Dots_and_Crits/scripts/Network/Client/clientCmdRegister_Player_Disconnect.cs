function clientCmdRegister_Player_Disconnect(%Game_Connection_Handle)
{
echo(%Game_Connection_Handle SPC "disconnected.");

for (%x=0;%x<$Simset_Players_Information.getCount();%x++)
{

%Player_Information=$Simset_Players_Information.getObject(%x);

if (%Player_Information.Game_Connection_Handle==%Game_Connection_Handle)
{

if ($Bool_Is_Playing)
{

Module_Player_Class.Player_Data_Remove(%Player_Information);

}

%Player_Information.delete();

return;

}

}

}

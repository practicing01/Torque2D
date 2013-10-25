function serverCmdRegister_Map_To_Load(%Client,%Player_Name,%Module_ID_Map)
{

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

commandToClient(%Object,'Register_Map_To_Load',%Player_Name,%Module_ID_Map);

}

}

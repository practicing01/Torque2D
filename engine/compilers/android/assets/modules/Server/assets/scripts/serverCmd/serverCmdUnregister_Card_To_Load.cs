function serverCmdUnregister_Card_To_Load(%Client,%Module_ID_Card)
{

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

commandToClient(%Object,'Unregister_Card_To_Load',%Module_ID_Card);

}

}

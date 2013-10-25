function serverCmdSet_Server_Name(%Client,%Server_Name)
{

echo(%Client.Connector_Name SPC "set its name to" SPC %Server_Name);

%Client.Connector_Name=%Server_Name;

}

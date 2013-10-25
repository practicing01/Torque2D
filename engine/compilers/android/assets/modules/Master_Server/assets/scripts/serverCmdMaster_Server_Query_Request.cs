function serverCmdMaster_Server_Query_Request(%Client)
{
echo("Got query request from:" SPC %Client);

//Go through list of connected servers and send their info to the client who requested a query.
for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

if (%Object.Connector_Type$="Server")
{

echo(%Object.Connector_Name SPC %Object.IP_Address SPC %Object.Connector_Type);

commandToClient(%Client,'Query_Response',false,%Object.Connector_Name,%Object.IP_Address);

}

}

commandToClient(%Client,'Query_Response',true);

}

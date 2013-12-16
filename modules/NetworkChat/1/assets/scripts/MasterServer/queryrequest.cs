function serverCmdMasterServer_queryrequest(%client)
{
echo("got query request from:" SPC %client);

//go through list of connected servers and send their info to the client who requested a query
for (%x=0;%x<ClientGroup.getCount();%x++)
{

%obj=ClientGroup.getObject(%x);

if (%obj.connectortype$="Server")
{

echo(%obj.connectorname SPC %obj.ipaddress SPC %obj.connectortype);

commandToClient(%client,'QueryResponse',false,%obj.connectorname,%obj.ipaddress);

//schedule(1000*%x,0,"commandToClient",%client,'QueryResponse',false,%obj.connectorname,%obj.ipaddress);

}

}

commandToClient(%client,'QueryResponse',true);
//if use schedule, schedule the above too

}

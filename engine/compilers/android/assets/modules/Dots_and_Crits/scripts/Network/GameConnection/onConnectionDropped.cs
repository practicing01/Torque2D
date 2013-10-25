function GameConnection::onConnectionDropped(%this,%reason)
{

echo("Game connection dropped. reason:" SPC %reason);

if (!$Bool_Is_Client)
{

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

if (%Object.Connector_Type$="Client"&&%Object!=%this)
{

commandToClient(%Object,'Register_Player_Disconnect',%this);

}

}

}

}

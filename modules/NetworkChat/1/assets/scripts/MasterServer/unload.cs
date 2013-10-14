function NetworkChat::MasterServer_unload(%this)
{

echo("unloaded Master Server");

allowConnections(false);

if (isObject(%this.gameconnection_connection))
{
%this.gameconnection_connection.delete();
}

}

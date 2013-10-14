function NetworkChat::Server_unload(%this)
{

echo("unloaded Server");

allowConnections(false);

if (isObject(%this.gameconnection_connection))
{
%this.gameconnection_connection.delete();
}

}

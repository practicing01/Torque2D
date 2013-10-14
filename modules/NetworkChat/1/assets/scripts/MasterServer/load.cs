function NetworkChat::MasterServer_load(%this)
{

echo("loaded Master Server");

setNetPort(9000);

allowConnections(true);

if (isObject(%this.gameconnection_connection))
{
%this.gameconnection_connection.delete();
}
else
{
%this.gameconnection_connection=new GameConnection();
}

}

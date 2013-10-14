function NetworkChat::Client_unload(%this)
{

echo("unloaded Client");

if (isObject(%this.gameconnection_connection))
{
%this.gameconnection_connection.delete();
}

}

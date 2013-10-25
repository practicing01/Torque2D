function Dots_and_Crits::Client_Unload(%this)
{

echo("Unloaded Client");

if (isObject($GameConnection_Connection))
{
$GameConnection_Connection.delete();
}

}

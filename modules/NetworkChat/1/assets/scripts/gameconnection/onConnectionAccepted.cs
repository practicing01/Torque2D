function GameConnection::onConnectionAccepted(%this)//client
{

echo("game onConnection accepted." SPC %this);

if ($handle_NetworkChat.gameconnection_masterserverquery!=0)//this is a query connection
{

echo("querying");

if (isObject($handle_NetworkChat.simset_serverlist))
{
$handle_NetworkChat.simset_serverlist.deleteObjects();
}

gui_list_serverlist.clearItems();

commandToServer('MasterServer_queryrequest');

}


}

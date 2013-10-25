function Dots_and_Crits::Query_Master_Server(%this)
{

if ($GameConnection_Master_Server_Query==0)//Not Connected
{

$GameConnection_Master_Server_Query=new GameConnection();

$GameConnection_Master_Server_Query.setConnectArgs
(
$String_Client_Name,//Connector Name
"Client",//Connector Type
$String_Player_Sprite//Player Sprite
);

if ($Bool_Is_Local_Connection)
{

echo("Connecting to the local master server for query.");

$GameConnection_Master_Server_Query.connect($IP_Master_Server);

}
else
{

//use internet ip

}

}

}

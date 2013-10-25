function Module_Server::Server_Connect(%this)
{

if ($Bool_Is_Local_Connection)
{

$GameConnection_Connection.connect($IP_Master_Server);

}
else
{

//use internet ip

}

}

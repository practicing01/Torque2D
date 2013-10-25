function Module_Master_Server::Scene_Initialize(%this)
{

$Bool_Is_Client=false;

$Bool_Is_Master_Server=true;

setNetPort(9000);

allowConnections(true);

if (isObject($GameConnection_Connection))
{

$GameConnection_Connection.delete();

}
else
{

$GameConnection_Connection=new GameConnection();

}

}

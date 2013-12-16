function gui_mainmenu::querymasterserver(%this)
{

//queryMasterServer(0,NULL,NULL,0,0,0,0,0,0,0);

//queryLanServers(9000,0,NULL,NULL,0,0,0,0,0,0,0);

if ($handle_NetworkChat.gameconnection_masterserverquery==0)//not connected
{

$handle_NetworkChat.gameconnection_masterserverquery=new GameConnection();

$handle_NetworkChat.gameconnection_masterserverquery.setConnectArgs
(
"NetworkChat Toy Client",//connector name
"127.0.0.1:9002",//ip address
"Client"//connector type
);

if ($handle_NetworkChat.is_local)
{

echo("connecting to master server for query");

$handle_NetworkChat.gameconnection_masterserverquery.connect("127.0.0.1:9000");//master server

}
else
{

//use internet ip

}

}

}

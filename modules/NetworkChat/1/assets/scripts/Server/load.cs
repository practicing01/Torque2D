function NetworkChat::Server_load(%this)
{

echo("loaded Server");

setNetPort(9001);

allowConnections(true);

if (isObject(%this.gameconnection_connection))
{
%this.gameconnection_connection.delete();
}
else
{

%this.gameconnection_connection=new GameConnection();

%this.gameconnection_connection.setConnectArgs
(
"NetworkChat Toy Server",//connector name
"127.0.0.1:9001",//ip address
"Server"//connector type
);

}

%this.Server_connect();

}

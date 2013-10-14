function NetworkChat::Client_load(%this)
{

echo("loaded Client");

setNetPort(9002);

allowConnections(false);

if (isObject(%this.gameconnection_connection))
{
%this.gameconnection_connection.delete();
}
else
{

%this.gameconnection_connection=new GameConnection();

%this.gameconnection_connection.setConnectArgs
(
"NetworkChat Toy Client",//connector name
"127.0.0.1:9002",//ip address
"Client"//connector type
);

}

}

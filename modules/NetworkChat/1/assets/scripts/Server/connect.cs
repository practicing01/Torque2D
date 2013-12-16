function NetworkChat::Server_connect(%this)
{

echo("server connecting to master server");

if (%this.is_local)
{

%this.gameconnection_connection.connect("127.0.0.1:9000");

}
else
{

//use internet ip

}

}

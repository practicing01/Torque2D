function gui_mainmenu::Connect_to_Server(%this)
{

//if connected to something, disconnect.  then connect to new server

if (gui_list_serverlist.getSelectedItem()!=-1)
{
%server_name=gui_list_serverlist.getItemText(gui_list_serverlist.getSelectedItem());

%server_obj=0;

for (%x=0;%x<$handle_NetworkChat.simset_serverlist.getCount();%x++)
{

%obj=$handle_NetworkChat.simset_serverlist.getObject(%x);

if (%obj.connectorname$=%server_name)
{
%server_obj=%obj;
break;
}

}

if (%server_obj==0){return;}

if ($handle_NetworkChat.gameconnection_masterserverquery!=0)
{
$handle_NetworkChat.gameconnection_masterserverquery.delete();
$handle_NetworkChat.gameconnection_masterserverquery=0;
}

if ($handle_NetworkChat.gameconnection_connection!=0)
{
$handle_NetworkChat.gameconnection_connection.delete();
$handle_NetworkChat.gameconnection_connection=0;
}

$handle_NetworkChat.gameconnection_connection=new GameConnection();

$handle_NetworkChat.gameconnection_connection.setConnectArgs
(
"NetworkChat Toy Client",//connector name
"127.0.0.1:9002",//ip address
"Client"//connector type
);

echo("connecting to server:" SPC %server_obj.connectorname);

$handle_NetworkChat.gameconnection_connection.connect(%server_obj.ipaddress);


}

}

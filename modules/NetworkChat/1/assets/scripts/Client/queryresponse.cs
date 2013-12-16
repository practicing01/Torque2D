function clientCmdQueryResponse(%done,%connectorname,%ipaddress)
{

//delete $handle_NetworkChat.gameconnection_masterserverquery after last response

if (!%done)
{

%server=new ScriptObject()
{
connectorname=%connectorname;
ipaddress=%ipaddress;
};

$handle_NetworkChat.simset_serverlist.add(%server);

gui_list_serverlist.addItem(%connectorname);

}
else
{

$handle_NetworkChat.gameconnection_masterserverquery.delete();
$handle_NetworkChat.gameconnection_masterserverquery=0;

}


}

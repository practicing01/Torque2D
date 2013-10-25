function GameConnection::onConnectionAccepted(%this)//client
{

echo("Game onConnectionAccepted." SPC %this);

if ($GameConnection_Master_Server_Query!=0)//this is a query connection
{

echo("Querying.");

if (isObject($Simset_Server_List))
{
$Simset_Server_List.deleteObjects();
}

/*No prototype for Gui_List_Servers, naughty code :y */
Gui_List_Servers.clearItems();

commandToServer('Master_Server_Query_Request');

}
else if ($GameConnection_Connection!=0&&$Bool_Is_Client)//this is a client to server connection
{

Module_Gui_Main_Menu.Scene_Unload();

Canvas.popDialog(Gui_Main_Menu);

Module_Gui_Server_Menu.Scene_Load();

}


}

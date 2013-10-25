function Module_Master_Server::Scene_Unload(%this)
{

$Bool_Is_Client=true;

$Bool_Is_Master_Server=false;

allowConnections(false);

if (isObject($GameConnection_Connection))
{

$GameConnection_Connection.delete();

}

Canvas.popDialog(Gui_Master_Server);

%this.Ass_Unload();

}

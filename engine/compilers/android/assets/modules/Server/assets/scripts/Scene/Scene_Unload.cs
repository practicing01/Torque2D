function Module_Server::Scene_Unload(%this)
{

$Bool_Is_Client=true;

allowConnections(false);

if (isObject($GameConnection_Connection))
{

$GameConnection_Connection.delete();

}

Canvas.popDialog(Gui_Server);

%this.Ass_Unload();

}

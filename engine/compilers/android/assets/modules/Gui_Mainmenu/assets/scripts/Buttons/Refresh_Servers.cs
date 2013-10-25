function Gui_Main_Menu::Refresh_Servers(%this)
{

if (isObject($Simset_Server_List))
{

$Simset_Server_List.deleteObjects();

}

Dots_and_Crits.Query_Master_Server();

}

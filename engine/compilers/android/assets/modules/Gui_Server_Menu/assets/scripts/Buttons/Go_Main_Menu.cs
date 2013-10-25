function Gui_Server_Menu::Go_Main_Menu(%this)
{

Module_Gui_Chat_Box.Scene_Unload();

Module_Gui_Server_Menu.Scene_Unload();

Module_Gui_Main_Menu.Scene_Load();

}

function Gui_Server_Menu::Play(%this)
{

if ($GameConnection_Connection!=0)
{

commandToServer('Register_Play',$GameConnection_Connection);

Module_Gui_Server_Menu.Scene_Unload();

}

}

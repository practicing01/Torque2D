function Gui_Config_Menu::Set_Server_Name(%this)
{

Module_Server.Server_Name=Gui_Textedit_Server_Name.getText();

commandToServer('Set_Server_Name',Module_Server.Server_Name);

}

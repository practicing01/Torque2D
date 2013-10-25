function Gui_Server_Menu::Select_Map(%this)
{

if ($GameConnection_Connection!=0)
{

if (Gui_List_Server_Menu_Maps.getSelectedItem()!=-1)
{

%Map_Name=Gui_List_Server_Menu_Maps.getItemText(Gui_List_Server_Menu_Maps.getSelectedItem());

$String_Map_To_Load=%Map_Name;

commandToServer('Register_Map_To_Load',$String_Client_Name,%Map_Name);

}

}

}

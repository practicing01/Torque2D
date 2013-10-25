function Gui_Server_Menu::Ready(%this)
{

Module_Gui_Server_Menu.Bool_Client_Ready=!Module_Gui_Server_Menu.Bool_Client_Ready;

if ($GameConnection_Connection!=0)
{

if (Module_Gui_Server_Menu.Bool_Client_Ready)
{

%Text=$String_Client_Name @ " is ready.";

}
else
{

%Text=$String_Client_Name @ " is not ready.";

}

commandToServer('Send_Text',%Text);

}

}

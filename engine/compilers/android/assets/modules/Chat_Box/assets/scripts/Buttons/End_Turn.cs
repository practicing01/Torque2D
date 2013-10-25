function Gui_Chat_Box::End_Turn(%this)
{

if ($GameConnection_Connection!=0)
{

%Text=$String_Client_Name SPC "ends the turn.";

commandToServer('Send_Text',%Text);

Gui_MLTextEdit_Chat_Box.setText("");

}

}

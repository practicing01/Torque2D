function Gui_Chat_Box::Roll_Dice(%this)
{

if ($GameConnection_Connection!=0)
{

%Text=$String_Client_Name SPC "rolls" SPC getRandom(1,20) @ "/20";

commandToServer('Send_Text',%Text);

Gui_MLTextEdit_Chat_Box.setText("");

}

}

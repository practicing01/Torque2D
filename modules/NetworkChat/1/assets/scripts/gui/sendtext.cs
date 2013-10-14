function gui_mainmenu::sendtext(%this,%text)
{


%text=gui_mltextedit_chatbox.getText();

commandToServer('Send_Text',%text);

}

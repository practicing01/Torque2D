function serverCmdSend_Text(%Client,%Text)
{

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

commandToClient(%Object,'Recieve_Text',%Text);

}

}

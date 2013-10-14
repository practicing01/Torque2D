function serverCmdSend_Text(%client,%text)
{

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%obj=ClientGroup.getObject(%x);

commandToClient(%obj,'Recieve_Text',%text);

}

}

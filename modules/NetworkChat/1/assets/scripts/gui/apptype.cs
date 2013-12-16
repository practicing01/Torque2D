function gui_mainmenu::apptype(%this,%type)
{

if ($handle_NetworkChat.apptype==0)//master server
{
$handle_NetworkChat.MasterServer_unload();
}
else if ($handle_NetworkChat.apptype==1)//server
{
$handle_NetworkChat.Server_unload();
}
else if ($handle_NetworkChat.apptype==2)//client
{
$handle_NetworkChat.Client_unload();
}

$handle_NetworkChat.apptype=%type;

if ($handle_NetworkChat.apptype==0)//master server
{
$handle_NetworkChat.MasterServer_load();
}
else if ($handle_NetworkChat.apptype==1)//server
{
$handle_NetworkChat.Server_load();
}
else if ($handle_NetworkChat.apptype==2)//client
{
$handle_NetworkChat.Client_load();
}

}

//-----------------------------------------------------------------------------
// Copyright (c) 2013 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

exec("./assets/scripts/gui/mainmenu.cs");
exec("./assets/scripts/gameconnection/gameconnection.cs");
//exec("./assets/scripts/onServerQueryStatus/onServerQueryStatus.cs");//not used and not fully understood
exec("./assets/scripts/MasterServer/MasterServer.cs");
exec("./assets/scripts/Server/Server.cs");
exec("./assets/scripts/Client/Client.cs");

function NetworkChat::create( %this )
{

    %this.gameconnection_connection=0;
    
    %this.gameconnection_masterserverquery=0;
    
    %this.is_local=true;//local or internet
    
    %this.simset_serverlist=0;
    
    // Reset the toy.    
    %this.reset();
}

//-----------------------------------------------------------------------------

function NetworkChat::destroy( %this )
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

if (isObject(%this.simset_serverlist))
{
%this.simset_serverlist.delete();
}

closeNetPort();

deleteVariables("$handle_NetworkChat");

}

//-----------------------------------------------------------------------------

function NetworkChat::reset( %this )
{
    // Clear the scene.
    SandboxScene.clear();
    
    $pref::Master[0] = "2:127.0.0.1:9000";
    
    $handle_NetworkChat=%this;
    
    if (%this.gameconnection_masterserverquery!=0)
    {
    %this.gameconnection_masterserverquery.delete();
    %this.gameconnection_masterserverquery=0;
    }
    
    if (%this.gameconnection_connection!=0)
    {
    %this.gameconnection_connection.delete();
    %this.gameconnection_connection=0;
    }
    
    if (isObject(%this.simset_serverlist))
    {
    %this.simset_serverlist.delete();
    }
    %this.simset_serverlist=new SimSet();
    
    %this.is_local=true;
 
    %this.apptype=0;//0=master server, 1=server, 2=client
    %this.MasterServer_load();
   
    Sandbox.add(TamlRead("./assets/gui/mainmenu.gui.taml"));
    
    Canvas.pushDialog(gui_mainmenu);
    
}

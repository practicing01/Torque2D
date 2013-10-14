function GameConnection::onConnect(%this,%arg0,%arg1,%arg2,%arg3,%arg4,%arg5,%arg6,
%arg7,%arg8,%arg9,%arg10,%arg11,%arg12,%arg13,%arg14,%arg15)//Master Server/Server callback
{

echo("game onConnected. info:" SPC %this);
echo(%arg0 SPC %arg1 SPC %arg2 SPC %arg3 SPC %arg4 SPC %arg5 SPC
%arg6 SPC %arg7 SPC %arg8 SPC %arg9 SPC %arg10 SPC %arg11 SPC
%arg12 SPC %arg13 SPC %arg14 SPC %arg15);
echo(%this.getAddress());
%this.connectorname=%arg0;
%this.ipaddress=%this.getAddress();//%arg1;
%this.connectortype=%arg2;//"Client" or "Server"

}

function onServerQueryStatus(%status,%message)
{

echo("master query status:" SPC %status SPC "message:" SPC %message);

if (%status$="done")//populate server list
{

%servercount=getServerCount();

for (%x=0;%x<%servercount;%x++)
{

setServerInfo(%x);

echo($ServerInfo::Status);
echo($ServerInfo::Address);
echo($ServerInfo::Name);
echo($ServerInfo::GameType);
echo($ServerInfo::MissionName);
echo($ServerInfo::MissionType);
echo($ServerInfo::State);
echo($ServerInfo::Info);
echo($ServerInfo::PlayerCount);
echo($ServerInfo::MaxPlayers);
echo($ServerInfo::BotCount);
echo($ServerInfo::Version);
echo($ServerInfo::Ping);
echo($ServerInfo::CPUSpeed);
echo($ServerInfo::Favorite);
echo($ServerInfo::Dedicated);
echo($ServerInfo::Password);

}

}

}

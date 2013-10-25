function Module_Map_Deathball_Valley::Player_Spawn(%this,%Sprite_Player)
{

%Portal_Spawn=%this.Simset_Portal_Spawn.getObject(getRandom(0,%this.Simset_Portal_Spawn.getCount()-1));

%Sprite_Player.Position=%Portal_Spawn.Position;

Window_Dots_and_Crits.setCameraPosition(%Portal_Spawn.Position.X,%Portal_Spawn.Position.Y);

}

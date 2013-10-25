function Module_Map_Deathball_Valley::Player_Health(%this,%Player_Information)
{

if (%Player_Information.Health<=0)
{

commandToServer('Relay_Module_Function',%Player_Information.Composite_Sprite.Module_ID_Parent,"Action_Update_Health",100);

%this.Player_Spawn(%Player_Information.Composite_Sprite);

commandToServer('Relay_Module_Function',%Player_Information.Composite_Sprite.Module_ID_Parent,"Action_Position",%Player_Information.Composite_Sprite.Position);

}

}

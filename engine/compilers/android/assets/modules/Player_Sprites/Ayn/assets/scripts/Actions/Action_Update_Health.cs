function Module_Player_Sprite_Ayn::Action_Update_Health(%this,%Player_Information,%Health)
{

%Player_Information.Health+=%Health;

$Module_ID_Map_Loaded.Player_Health(%Player_Information);

}

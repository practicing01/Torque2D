function Module_Player_Sprite_Ayn::Gui_Button_Gui_Menu_Move(%this,%Vector_2D_World_Point)
{

commandToServer('Relay_Module_Function',Module_Player_Sprite_Ayn,"Action_Move",%Vector_2D_World_Point);

}

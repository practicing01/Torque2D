function Module_Player_Sprite_Ayn::Gui_Button_Gui_Menu_Emote(%this,%Composite_Sprite_Player_Parent)
{

%Script_Object_Player_Sprite=%Composite_Sprite_Player_Parent.Script_Object_Parent;

commandToServer('Relay_Module_Function',Module_Player_Sprite_Ayn,"Action_Emote",
%Script_Object_Player_Sprite.Asset_ID_Animation_Emote);

}

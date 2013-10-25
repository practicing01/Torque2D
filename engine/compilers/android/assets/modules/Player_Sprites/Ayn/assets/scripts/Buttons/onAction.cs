function Module_Player_Sprite_Ayn_Gui_Menu::onAction(%this)
{

if (%this.String_Action$="Move")
{

Module_Player_Sprite_Ayn.Bool_Waiting_For_Move=true;

}
else if (%this.String_Action$="Config")
{

Module_Player_Sprite_Ayn.Gui_Button_Gui_Menu_Config(%this.Composite_Sprite_Player_Parent);

}
else if (%this.String_Action$="Emote")
{

Module_Player_Sprite_Ayn.Gui_Button_Gui_Menu_Emote(%this.Composite_Sprite_Player_Parent);

}
else if (%this.String_Action$="Attack")
{

Module_Player_Sprite_Ayn.Bool_Waiting_For_Attack=true;

}

}

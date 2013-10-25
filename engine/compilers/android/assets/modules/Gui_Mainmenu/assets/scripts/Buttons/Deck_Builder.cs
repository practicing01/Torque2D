function Gui_Main_Menu::Deck_Builder_Open(%this)
{

Module_Gui_Main_Menu.Scene_Unload();

Canvas.popDialog(Gui_Main_Menu);

Module_Gui_Deck_Builder.Scene_Load();

}

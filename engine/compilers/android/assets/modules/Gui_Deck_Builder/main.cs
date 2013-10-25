function Module_Gui_Deck_Builder::create(%this)
{

exec("./assets/scripts/Scene/Scene_Load.cs");
exec("./assets/scripts/Scene/Scene_Unload.cs");

}

function Module_Gui_Deck_Builder::destroy(%this)
{

%this.Scene_Unload();

if (isObject(%this.Scene_Current))
{

%this.Scene_Current.delete();

}

Scene_Create_Dots_and_Crits();

}

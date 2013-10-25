exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Initialize_Variables.cs");
exec("./Scene_Initialize.cs");
exec("./../Buttons/Buttons.cs");

function Module_Gui_Chat_Box::Scene_Load(%this)
{

%this.Ass_Load();

if (!isObject(Gui_Chat_Box))
{

Dots_and_Crits.add(TamlRead("./../../gui/Gui_Chat_Box.gui.taml"));

}

Canvas.pushDialog(Gui_Chat_Box);

%this.Initialize_Variables();

%this.Scene_Initialize();

}

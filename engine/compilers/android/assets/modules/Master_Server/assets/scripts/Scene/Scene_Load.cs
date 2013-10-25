exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Initialize_Variables.cs");
exec("./Scene_Initialize.cs");
exec("./../Buttons/Buttons.cs");
exec("./../serverCmdMaster_Server_Query_Request.cs");
exec("./../serverCmdSet_Server_Name.cs");

function Module_Master_Server::Scene_Load(%this)
{

%this.Ass_Load();

Cancel_All_Schedules();

Scene_Dots_and_Crits.clear();

%this.Scene_Current=TamlRead("./../../scenes/Module_Master_Server.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

if (!isObject(Gui_Master_Server))
{

Dots_and_Crits.add(TamlRead("./../../gui/Gui_Master_Server.gui.taml"));

}

Canvas.pushDialog(Gui_Master_Server);

%this.Initialize_Variables();

%this.Scene_Initialize();

}

function Dots_and_Crits::create(%this)/*Clusterfuck of Core code, needs to be redesigned*/
{

/*Core Misc*/
exec("./scripts/Misc/Init_Misc.cs");

initializeCanvas("Dots_and_Crits");

Canvas.BackgroundColor="black";
Canvas.UseBackgroundColor=true;

initializeOpenAL();

/*Gui Init*/
exec("./gui/guiProfiles.cs");

/*Global Variables*/
exec("./scripts/Global_Variables/Global_Variables.cs");

/*Global Functions*/
exec("./scripts/Init_Functions/Init_Functions.cs");

/*Core Scene*/
exec("./scenes/Scene_Dots_and_Crits.cs");

/*Core Network*/
exec("./scripts/Network/Network.cs");

/*Load Play*/
exec("./scripts/Load_Play/Load_Play.cs");

/*Pause Menu*/
exec("./gui/Gui_Pause_Menu/Gui_Pause_Menu.cs");

/*Card Slots*/
exec("./gui/Gui_Card_Slot_Button/Gui_Card_Slot_Button.cs");

Window_Create_Dots_and_Crits();
Scene_Create_Dots_and_Crits();

Dots_and_Crits.add(TamlRead("./gui/ConsoleDialog.gui.taml"));
GlobalActionMap.bind(keyboard,"tilde",toggleConsole);

new RenderProxy(CannotRenderProxy)
{
Image="Dots_and_Crits:CannotRender";
};
Dots_and_Crits.add(CannotRenderProxy);

$Camera_Size=Window_Dots_and_Crits.getCameraSize();

%Local_Time=getLocalTime();
%Local_Time=stripChars(%Local_Time,":/");
%Local_Time=getWord(%Local_Time,0)+getWord(%Local_Time,1);
setRandomSeed(%Local_Time);

ModuleDatabase.LoadExplicit("Splashes");
Splashes.Scene_Load();

}

function Dots_and_Crits::destroy(%this)
{
Window_Destroy_Dots_and_Crits();
}

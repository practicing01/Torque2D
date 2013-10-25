if (!isObject(Gui_Pause_Menu))
{

Dots_and_Crits.add(TamlRead("./Gui_Pause_Menu.gui.taml"));

}

exec("./Buttons/Go_Main_Menu.cs");


function Dots_and_Crits::Toggle_Pause_Menu(%this)
{

if ($Bool_Is_Playing)
{

if (!Gui_Pause_Menu.isAwake())
{

Canvas.pushDialog(Gui_Pause_Menu);

}
else
{

Canvas.popDialog(Gui_Pause_Menu);

}

}

}

//GlobalActionMap.bindCmd(keyboard,"escape","Dots_and_Crits.Toggle_Pause_Menu();","");

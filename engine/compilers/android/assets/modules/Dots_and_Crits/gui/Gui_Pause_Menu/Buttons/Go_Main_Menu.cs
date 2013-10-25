function Gui_Pause_Menu::Go_Main_Menu(%this)
{

if ($GameConnection_Connection!=0)
{

if (isObject($GameConnection_Connection)){$GameConnection_Connection.delete();}

$GameConnection_Connection=0;

}

Module_Player_Class.Player_Data_Clear();

if (isObject($Simset_Players_Information))
{

$Simset_Players_Information.deleteObjects();

}

if (isObject($Simset_ModuleID_Player_Sprites))
{

$Simset_ModuleID_Player_Sprites.deleteObjects();

}

$Module_ID_Map_Loaded=0;

if (isObject($Simset_Deck_To_Load))
{

for (%x=0;%x<$Simset_Cards_To_Load.getCount();%x++)
{

%Object=$Simset_Cards_To_Load.getObject(%x);

ModuleDatabase.unloadExplicit(%Object.Module_ID_Card);

}

$Simset_Deck_To_Load.deleteObjects();

}

/***********************************************/
/************ Delete Gui's **********************/

for (%x=0;%x<Window_Dots_and_Crits.getCount();%x++)
{

%Gui_Child=Window_Dots_and_Crits.getObject(%x);

if (%Gui_Child.Bool_Delete_Me==true)
{

Window_Dots_and_Crits.remove(%Gui_Child);

%Gui_Child.deleteObjects();

%Gui_Child.delete();

%x=-1;//Restart loop because we just modified the count.

}

}

/***********************************************/

$Bool_Is_Playing=false;

Module_Gui_Chat_Box.Scene_Unload();

Canvas.popDialog(Gui_Pause_Menu);

Module_Gui_Main_Menu.Scene_Load();

}

function Module_Gui_Server_Menu::Scene_Initialize(%this)
{

Module_Gui_Chat_Box.Scene_Load();

Gui_List_Server_Menu_Decks.clearItems();

/*Search for maps.*/

Gui_List_Server_Menu_Maps.clearItems();

%Map_Modules=ModuleDatabase.findModuleTypes("Map",false);

if (isObject($Simset_ModuleID_Maps))
{

$Simset_ModuleID_Maps.deleteObjects();

$Simset_ModuleID_Maps.delete();

}

$Simset_ModuleID_Maps=new SimSet();

%Map_Count=getWordCount(%Map_Modules);

for (%x=0;%x<%Map_Count;%x++)
{

%Module_ID_Map=getWord(%Map_Modules,%x);

ModuleDatabase.LoadExplicit(%Module_ID_Map.ModuleId);

%Script_Object_Map=new ScriptObject()
{
Module_ID_Map=%Module_ID_Map.ModuleId;
String_Description=%Module_ID_Map.Description;
};

$Simset_ModuleID_Maps.add(%Script_Object_Map);

Gui_List_Server_Menu_Maps.addItem(%Module_ID_Map.Description);

}

/*Search for decks.*/

Gui_List_Server_Menu_Decks.clearItems();

%String_Deck_Files=getFileList("./../../../../Decks");

if (!isObject(%this.Simset_Deck_Filenames))
{

%this.Simset_Deck_Filenames=new SimSet();

}

%this.Simset_Deck_Filenames.deleteObjects();

%Deck_Count=getWordCount(%String_Deck_Files);

for (%x=0;%x<%Deck_Count;%x++)
{

%File_Name_Deck=getWord(%String_Deck_Files,%x);

%Script_Object_Deck=new ScriptObject()
{
File_Name_Deck=%File_Name_Deck;
};

%this.Simset_Deck_Filenames.add(%Script_Object_Deck);

Gui_List_Server_Menu_Decks.addItem(fileBase(fileBase(%File_Name_Deck)));

}

if (isObject($Simset_Cards_To_Load))
{

$Simset_Cards_To_Load.deleteObjects();
$Simset_Cards_To_Load.delete();

}

$Simset_Cards_To_Load=new SimSet();

}

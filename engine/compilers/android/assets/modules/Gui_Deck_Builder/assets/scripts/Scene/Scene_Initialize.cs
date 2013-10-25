function Module_Gui_Deck_Builder::Scene_Initialize(%this)
{

Gui_List_Deck_Builder_Deck_Cards.clearItems();

/*Search for cards.*/

Gui_List_Deck_Builder_Cards.clearItems();

%Card_Modules=ModuleDatabase.findModuleTypes("Card",false);

if (!isObject(%this.Simset_ModuleID_Cards))
{

%this.Simset_ModuleID_Cards=new SimSet();

}

%this.Simset_ModuleID_Cards.clear();

%Card_Count=getWordCount(%Card_Modules);

for (%x=0;%x<%Card_Count;%x++)
{

%Module_ID_Card=getWord(%Card_Modules,%x);

ModuleDatabase.LoadExplicit(%Module_ID_Card.ModuleId);

%Script_Object_Card=new ScriptObject()
{
Module_ID_Card=%Module_ID_Card.ModuleId;
String_Description=%Module_ID_Card.Description;
};

%this.Simset_ModuleID_Cards.add(%Script_Object_Card);

Gui_List_Deck_Builder_Cards.addItem(%Module_ID_Card.Description);

}

}

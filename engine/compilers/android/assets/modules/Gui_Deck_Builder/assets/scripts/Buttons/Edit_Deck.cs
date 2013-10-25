function Gui_Deck_Builder::Edit_Deck(%this)
{

%Dialog_Open_File=new OpenFileDialog()
{
DefaultPath="modules/Decks";
DefaultFile="New_Deck.asset.taml";
Title="Name Deck to Edit";
fileName="New_Deck.asset.taml";
};

%Bool_Read_Success=%Dialog_Open_File.Execute();

if (!%Bool_Read_Success){return;}

Module_Gui_Deck_Builder.String_Deck_File_Name=%Dialog_Open_File.fileName;

if (isObject(Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards))
{

Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.deleteObjects();

Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.delete();

}

Gui_List_Deck_Builder_Deck_Cards.clearItems();

%Taml_Read_Object=TamlRead(Module_Gui_Deck_Builder.String_Deck_File_Name);

if (%Taml_Read_Object!$=0)
{

Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards=%Taml_Read_Object;

for (%x=0;%x<Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.getCount();%x++)
{

%Script_Object_Card=Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.getObject(%x);

%Module_ID_Card=%Script_Object_Card.Module_ID_Card;

%Module_Definition=ModuleDatabase.findModule(%Module_ID_Card,1);

Gui_List_Deck_Builder_Deck_Cards.addItem(%Module_Definition.Description);

ModuleDatabase.LoadExplicit(%Script_Object_Card.Module_ID_Card);

%Script_Object_Card.Module_ID_Card.Card_Preload();

/*******************************/

%GuiDragAndDropControl=new GuiDragAndDropControl()
{

class="Class_Deck_Builder_Card_Slot";
deleteOnMouseUp="0";
Extent="50 50";
HorizSizing="relative";
VertSizing="relative";
isContainer="1";
Position=%Script_Object_Card.Card_Slot_Position;
Profile="GuiDefaultProfile";

Script_Object_Card=%Script_Object_Card;

};

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

Extent="50 50";
Position="0 0";
Profile="gui_profile_modalless";

Animation=%Script_Object_Card.Module_ID_Card.Ass_Animation_Icon;

};

%GuiDragAndDropControl.addGuiControl(%GuiSpriteCtrl);

Gui_Deck_Builder.addGuiControl(%GuiDragAndDropControl);

/*******************************/

}

}

}

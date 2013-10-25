function Gui_Deck_Builder::Add_Card(%this)
{

if (isObject(Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards))
{

if (Gui_List_Deck_Builder_Cards.getSelectedItem()!=-1)
{

%Module_ID_Card=Module_Gui_Deck_Builder.Simset_ModuleID_Cards.getObject
(Gui_List_Deck_Builder_Cards.getSelectedItem()).Module_ID_Card;

//Check if already have this card.
for (%x=0;%x<Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.getCount();%x++)
{

%Card=Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.getObject(%x);

if (%Card.Module_ID_Card$=%Module_ID_Card)
{

return;

}

}

%Script_Object_Card=new ScriptObject()
{
Module_ID_Card=%Module_ID_Card;
Card_Slot_Position="0 0";
};

Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.add(%Script_Object_Card);

%Module_Definition=ModuleDatabase.findModule(%Module_ID_Card,1);

Gui_List_Deck_Builder_Deck_Cards.addItem(%Module_Definition.Description);

ModuleDatabase.LoadExplicit(%Script_Object_Card.Module_ID_Card);

%Script_Object_Card.Module_ID_Card.Card_Preload();

/*****************************************/

%GuiDragAndDropControl=new GuiDragAndDropControl()
{

class="Class_Deck_Builder_Card_Slot";
deleteOnMouseUp="0";
Extent="50 50";
HorizSizing="relative";
VertSizing="relative";
isContainer="1";
Position="375 215";
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

/*****************************************/

}

}

}

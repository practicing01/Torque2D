function Gui_Deck_Builder::Remove_Card(%this)
{

if (isObject(Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards))
{

if (Gui_List_Deck_Builder_Deck_Cards.getSelectedItem()!=-1)
{

%Script_Object_Card=Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.getObject
(Gui_List_Deck_Builder_Deck_Cards.getSelectedItem());

ModuleDatabase.unloadExplicit(%Script_Object_Card.Module_ID_Card);

Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.remove(%Script_Object_Card);

/*************************/

for (%x=0;%x<Gui_Deck_Builder.getCount();%x++)
{

%Card_Slot=Gui_Deck_Builder.getObject(%x);

if (%Card_Slot.class$="Class_Deck_Builder_Card_Slot")
{

if (%Card_Slot.Script_Object_Card==%Script_Object_Card)
{

Gui_Deck_Builder.remove(%Card_Slot);

%Card_Slot.deleteObjects();

%Card_Slot.delete();

break;

}

}

}

/*************************/

%Script_Object_Card.delete();

Gui_List_Deck_Builder_Deck_Cards.deleteItem
(Gui_List_Deck_Builder_Deck_Cards.getSelectedItem());

Gui_List_Deck_Builder_Deck_Cards.clearSelection();

}

}

}

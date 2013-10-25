function Gui_Deck_Builder::Save_Deck(%this)
{

if (Module_Gui_Deck_Builder.String_Deck_File_Name!$=0
&&
isObject(Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards))
{

/***********************************/

for (%y=0;%y<Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.getCount();%y++)
{

%Card=Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.getObject(%y);

for (%x=0;%x<Gui_Deck_Builder.getCount();%x++)
{

%Card_Slot=Gui_Deck_Builder.getObject(%x);

if (%Card_Slot.class$="Class_Deck_Builder_Card_Slot")
{

if (%Card_Slot.Script_Object_Card==%Card)
{

%Card.Card_Slot_Position=%Card_Slot.Position;

break;

}

}

}

}

/***********************************/

%Bool_Write_Success=TamlWrite(Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards,Module_Gui_Deck_Builder.String_Deck_File_Name);

if (%Bool_Write_Success){echo("Saved deck to " SPC Module_Gui_Deck_Builder.String_Deck_File_Name);}
else{echo("Couldn't save deck to" SPC Module_Gui_Deck_Builder.String_Deck_File_Name);}

}


}

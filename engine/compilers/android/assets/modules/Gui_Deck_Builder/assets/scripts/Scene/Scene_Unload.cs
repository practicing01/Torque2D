function Module_Gui_Deck_Builder::Scene_Unload(%this)
{

for (%x=0;%x<Gui_Deck_Builder.getCount();%x++)
{

%Gui_Child=Gui_Deck_Builder.getObject(%x);

if (%Gui_Child.class$="Class_Deck_Builder_Card_Slot")
{

%Gui_Child.deleteObjects();

Gui_Deck_Builder.remove(%Gui_Child);

%Gui_Child.delete();

%x=0;//Restart loop because we just modified the count.

}

}

if (isObject(%this.Simset_ModuleID_Cards))
{

%this.Simset_ModuleID_Cards.deleteObjects();

%this.Simset_ModuleID_Cards.delete();

}

if (isObject(%this.Simset_ModuleID_Deck_Cards))
{

for (%x=0;%x<%this.Simset_ModuleID_Deck_Cards.getCount();%x++)
{

%Script_Object_Card=Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.getObject(%x);

ModuleDatabase.unloadExplicit(%Script_Object_Card.Module_ID_Card);

}

%this.Simset_ModuleID_Deck_Cards.deleteObjects();

%this.Simset_ModuleID_Deck_Cards.delete();

}

Canvas.popDialog(Gui_Deck_Builder);

%this.Ass_Unload();

}

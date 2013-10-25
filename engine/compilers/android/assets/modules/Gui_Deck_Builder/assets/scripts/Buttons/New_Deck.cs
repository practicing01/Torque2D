function Gui_Deck_Builder::New_Deck(%this)
{

%Dialog_Save_File=new SaveFileDialog()
{
DefaultPath="modules/Decks";
DefaultFile="New_Deck.asset.taml";
Title="Name New Deck";
fileName="New_Deck.asset.taml";
};

%Bool_Write_Success=%Dialog_Save_File.Execute();

if (!%Bool_Write_Success){return;}

Module_Gui_Deck_Builder.String_Deck_File_Name=%Dialog_Save_File.fileName;

if (isObject(Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards))
{

Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.deleteObjects();

Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards.delete();

}

Module_Gui_Deck_Builder.Simset_ModuleID_Deck_Cards=new SimSet();

}

function Gui_Server_Menu::Select_Deck(%this)
{

if ($GameConnection_Connection!=0)
{

if (Gui_List_Server_Menu_Decks.getSelectedItem()!=-1)
{

if ($Simset_Deck_To_Load!=0)//Deck has been previously selected, erase.
{

for (%x=0;%x<$Simset_Deck_To_Load.getCount();%x++)
{

%Script_Object_Card=$Simset_Deck_To_Load.getObject(%x);

commandToServer('Unregister_Card_To_Load',%Script_Object_Card.Module_ID_Card);

}

$Simset_Deck_To_Load.deleteObjects();

$Simset_Deck_To_Load.delete();

$Simset_Deck_To_Load=0;

}

%Deck_Name=Gui_List_Server_Menu_Decks.getItemText(Gui_List_Server_Menu_Decks.getSelectedItem());

%Deck_Name="modules/Decks/"@%Deck_Name@".asset.taml";

%Card_List=TamlRead(%Deck_Name);

if (!isObject(%Card_List)){echo("Error Loading Deck.");return;}

for (%x=0;%x<%Card_List.getCount();%x++)
{

%Card=%Card_List.getObject(%x);

commandToServer('Register_Card_To_Load',%Card.Module_ID_Card);

}

/*%Card_List.deleteObjects();
%Card_List.delete();*/

$Simset_Deck_To_Load=%Card_List;

}

}

}

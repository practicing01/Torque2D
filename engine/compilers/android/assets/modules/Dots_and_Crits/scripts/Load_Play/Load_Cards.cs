function Dots_and_Crits::Load_Cards(%this)
{

if (!isObject($Simset_Cards_To_Load)){return;}

for (%x=0;%x<$Simset_Cards_To_Load.getCount();%x++)
{

%Object=$Simset_Cards_To_Load.getObject(%x);

ModuleDatabase.LoadExplicit(%Object.Module_ID_Card);

%Object.Module_ID_Card.Card_Load();

}

/***********************************/

if (!isObject($Simset_Deck_To_Load)){return;}

for (%x=0;%x<$Simset_Deck_To_Load.getCount();%x++)
{

%Script_Object_Card=$Simset_Deck_To_Load.getObject(%x);

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Card_Slot_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position=%Script_Object_Card.Card_Slot_Position;
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Animation=%Script_Object_Card.Module_ID_Card.Ass_Animation_Icon;

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Card_Slot_Button";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Card=%Script_Object_Card.Module_ID_Card;

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

}

/***********************************/

}

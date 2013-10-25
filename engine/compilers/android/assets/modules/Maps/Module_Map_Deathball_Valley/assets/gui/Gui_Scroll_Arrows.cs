function Module_Map_Deathball_Valley::Gui_Scroll_Arrows_Spawn(%this)
{

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position="50 0";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Up";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Up";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position="50 100";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Down";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Down";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position="0 50";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Left";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Left";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

%GuiSpriteCtrl=new GuiSpriteCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Sprite";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position="100 50";
Profile="GuiDefaultProfile";
isContainer="1";
canSaveDynamicFields="1";

Image="Module_Map_Deathball_Valley:Image_Scroll_Arrow_Right";

Bool_Delete_Me="1";

};

%GuiButtonCtrl=new GuiButtonCtrl()
{

class="Class_Module_Map_Deathball_Valley_Gui_Button_Scroll_Arrow";

HorizSizing="relative";
VertSizing="relative";
Extent="50 50";
Position="0 0";
Profile="GuiTransparentProfile";
isContainer="1";
canSaveDynamicFields="1";

Module_ID_Map=Module_Map_Deathball_Valley;

Arrow_Direction="Right";

Bool_Delete_Me="1";

};

%GuiSpriteCtrl.addGuiControl(%GuiButtonCtrl);

Window_Dots_and_Crits.addGuiControl(%GuiSpriteCtrl);

/**********************************************************/

}

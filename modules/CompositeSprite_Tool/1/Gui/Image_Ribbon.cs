function CompositeSprite_Tool::Create_Image_Ribbon(%this)
{

%this.GuiControl_Image_Ribbon=new GuiControl()
{

Profile="Gui_Profile_Modalless";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent=%this.Vector2D_Resolution;

};

%GuiScrollCtrl_Images=new GuiScrollCtrl()
{

Profile="GuiLightScrollProfile";

HorizSizing="relative";

VertSizing="relative";

Position="0 24";

Extent=%this.Vector2D_Resolution.X SPC "64";

hScrollBar="dynamic";

vScrollBar="alwaysOff";

};

%this.GuiControl_Image_Ribbon.add(%GuiScrollCtrl_Images);

%GuiDynamicCtrlArrayControl_Images=new GuiDynamicCtrlArrayControl()
{

Profile="Gui_List_Profile_Colored";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent="64 64";

colCount="1";

colSize="64";

colSpacing="0";

rowSize="64";

rowSpacing="0";

};

%GuiScrollCtrl_Images.add(%GuiDynamicCtrlArrayControl_Images);

/************************************************************/
//Populate ribbon.

//List to hold the results.
%String_Ass_Query=new AssetQuery();  

//Populate list, search for AssetCategory="Image".
AssetDatabase.findAssetCategory(%String_Ass_Query,"Image",false);  

//Loop through list if found any.
for (%x=0;%x<%String_Ass_Query.getCount();%x++)  
{

%Ass_ID=%String_Ass_Query.getAsset(%x);

%Ass=AssetDatabase.acquireAsset(%Ass_ID);

//Get the module the ass belongs to.
%Module_ID=AssetDatabase.getAssetModule(%Ass_ID);

//echo(%Module_ID.ModuleId);

//echo(%Ass.AssetCategory);

//Check if the module is the same as the one we're in.
if (%Module_ID.ModuleId$=%this.getName())
{

%GuiButtonCtrl_Ass=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent="64 64";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Ass";

};

%GuiDynamicCtrlArrayControl_Images.add(%GuiButtonCtrl_Ass);

%GuiDynamicCtrlArrayControl_Images.Extent.X+=64;

%GuiScrollCtrl_Images.computeSizes();

%GuiSpriteCtrl_Ass=new GuiSpriteCtrl()
{

Profile="Gui_Profile_Modalless";

Image=%Module_ID.ModuleId @ ":" @ %Ass.AssetName;

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent="64 64";

InternalName="GuiSpriteCtrl_Ass";

};

%GuiButtonCtrl_Ass.add(%GuiSpriteCtrl_Ass);

}

AssetDatabase.releaseAsset(%Ass.getAssetId());

}  

/************************************************************/

SandboxWindow.addGuiControl(%this.GuiControl_Image_Ribbon);

}

function CompositeSprite_Tool::Create_File_Toolbar(%this)
{

%this.GuiControl_File_Toolbar=new GuiControl()
{

Profile="Gui_Profile_Modalless";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent=%this.Vector2D_Resolution;

};

%GuiTextEditCtrl_Filename=new GuiTextEditCtrl()
{

Profile="GuiTextEditProfile";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent="160 24";

maxChars="255";

text="Level";

class="Class_CompositeSprite_Tool_GuiTextEditCtrl";

String_Type="Filename";

};

%this.GuiControl_File_Toolbar.add(%GuiTextEditCtrl_Filename);

%GuiButtonCtrl_Load=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="160 0";

Extent="160 24";

Text="Load";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Load";

};

%this.GuiControl_File_Toolbar.add(%GuiButtonCtrl_Load);

%GuiButtonCtrl_Save=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="320 0";

Extent="160 24";

Text="Save";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Save";

};

%this.GuiControl_File_Toolbar.add(%GuiButtonCtrl_Save);

%GuiButtonCtrl_Add_Background=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="480 0";

Extent="160 24";

Text="Add Background";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Add_Background";

};

%this.GuiControl_File_Toolbar.add(%GuiButtonCtrl_Add_Background);

%GuiButtonCtrl_Remove_Background=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="640 0";

Extent="160 24";

Text="Remove Background";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Remove_Background";

};

%this.GuiControl_File_Toolbar.add(%GuiButtonCtrl_Remove_Background);

SandboxWindow.addGuiControl(%this.GuiControl_File_Toolbar);

}

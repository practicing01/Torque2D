function Phyxel_Editor::Gui_Initialize( %this )
{

%this.GuiWindowCtrl_Tool_Window=new GuiWindowCtrl()
{

Profile=GuiDefaultProfile;

Position="0 0";

Extent="100 220";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

canClose="0";

canMaximize="0";

canMinimize="0";

resizeHeight="0";

resizeWidth="0";

};

SandboxWindow.addGuiControl(%this.GuiWindowCtrl_Tool_Window);

/****************************************************************/

%this.GuiTextEditCtrl_Color_Red=new GuiTextEditCtrl()
{

Profile="GuiTextEditProfile";

Position="0 20";

Extent="50 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

maxChars="255";

text="1.0";

class="Class_GuiTextEditCtrl_Color";

color="Red";

Module_ID_Parent=%this;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiTextEditCtrl_Color_Red);

%this.GuiButtonCtrl_Set_Red=new GuiButtonCtrl()
{

Profile=BlueButtonProfile;

Position="50 20";

Extent="50 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Red";

ButtonType="PushButton";

class="Class_GuiButtonCtrl_Color";

color=%this.GuiTextEditCtrl_Color_Red;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiButtonCtrl_Set_Red);

%this.GuiTextEditCtrl_Color_Green=new GuiTextEditCtrl()
{

Profile="GuiTextEditProfile";

Position="0 35";

Extent="50 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

maxChars="255";

text="1.0";

class="Class_GuiTextEditCtrl_Color";

color="Green";

Module_ID_Parent=%this;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiTextEditCtrl_Color_Green);

%this.GuiButtonCtrl_Set_Green=new GuiButtonCtrl()
{

Profile=BlueButtonProfile;

Position="50 35";

Extent="50 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Green";

ButtonType="PushButton";

class="Class_GuiButtonCtrl_Color";

color=%this.GuiTextEditCtrl_Color_Green;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiButtonCtrl_Set_Green);

%this.GuiTextEditCtrl_Color_Blue=new GuiTextEditCtrl()
{

Profile="GuiTextEditProfile";

Position="0 50";

Extent="50 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

maxChars="255";

text="1.0";

class="Class_GuiTextEditCtrl_Color";

color="Blue";

Module_ID_Parent=%this;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiTextEditCtrl_Color_Blue);

%this.GuiButtonCtrl_Set_Blue=new GuiButtonCtrl()
{

Profile=BlueButtonProfile;

Position="50 50";

Extent="50 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Blue";

ButtonType="PushButton";

class="Class_GuiButtonCtrl_Color";

color=%this.GuiTextEditCtrl_Color_Blue;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiButtonCtrl_Set_Blue);

%this.GuiTextEditCtrl_Color_Alpha=new GuiTextEditCtrl()
{

Profile="GuiTextEditProfile";

Position="0 65";

Extent="50 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

maxChars="255";

text="1.0";

class="Class_GuiTextEditCtrl_Color";

color="Alpha";

Module_ID_Parent=%this;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiTextEditCtrl_Color_Alpha);

%this.GuiButtonCtrl_Set_Alpha=new GuiButtonCtrl()
{

Profile=BlueButtonProfile;

Position="50 65";

Extent="50 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Alpha";

ButtonType="PushButton";

class="Class_GuiButtonCtrl_Color";

color=%this.GuiTextEditCtrl_Color_Alpha;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiButtonCtrl_Set_Alpha);

/****************************************************************/

%this.GuiButtonCtrl_Squiggle=new GuiButtonCtrl()
{

Profile=BlueButtonProfile;

Position="0 170";

Extent="100 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Squiggle Toggle";

ButtonType="PushButton";

class="Class_GuiButtonCtrl_Squiggle";

Module_ID_Parent=%this;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiButtonCtrl_Squiggle);

/****************************************************************/

%this.GuiButtonCtrl_Save=new GuiButtonCtrl()
{

Profile=BlueButtonProfile;

Position="0 185";

Extent="100 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Save Phyxel";

ButtonType="PushButton";

class="Class_GuiButtonCtrl_Save";

Module_ID_Parent=%this;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiButtonCtrl_Save);

/****************************************************************/

%this.GuiButtonCtrl_Load=new GuiButtonCtrl()
{

Profile=BlueButtonProfile;

Position="0 200";

Extent="100 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Load Phyxel";

ButtonType="PushButton";

class="Class_GuiButtonCtrl_Load";

Module_ID_Parent=%this;

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiButtonCtrl_Load);

/****************************************************************/

%this.GuiControl_Tool_Selection=new GuiControl()
{

Profile=GuiDefaultProfile;

Position="0 80";

Extent="100 90";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

};

%this.GuiWindowCtrl_Tool_Window.addGuiControl(%this.GuiControl_Tool_Selection);

%this.GuiRadioCtrl_Color_Phyxel=new GuiRadioCtrl()
{

Profile=GuiRadioProfile;

Position="0 0";

Extent="100 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Color Phyxel";

ButtonType="RadioButton";

class="Class_GuiRadioCtrl_Tool";

Mode="0";

Module_ID_Parent=%this;

};

%this.GuiRadioCtrl_Color_Phyxel.setStateOn(true);

%this.GuiControl_Tool_Selection.addGuiControl(%this.GuiRadioCtrl_Color_Phyxel);

%this.GuiRadioCtrl_Toggle_Phyxel=new GuiRadioCtrl()
{

Profile=GuiRadioProfile;

Position="0 15";

Extent="100 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Toggle Phyxel";

ButtonType="RadioButton";

class="Class_GuiRadioCtrl_Tool";

Mode="1";

Module_ID_Parent=%this;

};

%this.GuiControl_Tool_Selection.addGuiControl(%this.GuiRadioCtrl_Toggle_Phyxel);

%this.GuiRadioCtrl_Distance_Joint=new GuiRadioCtrl()
{

Profile=GuiRadioProfile;

Position="0 45";

Extent="100 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Distance Joint";

ButtonType="RadioButton";

class="Class_GuiRadioCtrl_Tool";

Mode="2";

Module_ID_Parent=%this;

};

%this.GuiControl_Tool_Selection.addGuiControl(%this.GuiRadioCtrl_Distance_Joint);

%this.GuiRadioCtrl_Weld_Joint=new GuiRadioCtrl()
{

Profile=GuiRadioProfile;

Position="0 60";

Extent="100 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Weld Joint";

ButtonType="RadioButton";

class="Class_GuiRadioCtrl_Tool";

Mode="4";

Module_ID_Parent=%this;

};

%this.GuiControl_Tool_Selection.addGuiControl(%this.GuiRadioCtrl_Weld_Joint);

%this.GuiRadioCtrl_Toggle_Squiggler=new GuiRadioCtrl()
{

Profile=GuiRadioProfile;

Position="0 30";

Extent="100 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Toggle Squiggler";

ButtonType="RadioButton";

class="Class_GuiRadioCtrl_Tool";

Mode="3";

Module_ID_Parent=%this;

};

%this.GuiControl_Tool_Selection.addGuiControl(%this.GuiRadioCtrl_Toggle_Squiggler);

%this.GuiRadioCtrl_Toggle_Heavy=new GuiRadioCtrl()
{

Profile=GuiRadioProfile;

Position="0 75";

Extent="100 15";

MinExtent="1 1";

HorizSizing="relative";

VertSizing="relative";

Text="Toggle Heavy";

ButtonType="RadioButton";

class="Class_GuiRadioCtrl_Tool";

Mode="5";

Module_ID_Parent=%this;

};

%this.GuiControl_Tool_Selection.addGuiControl(%this.GuiRadioCtrl_Toggle_Heavy);

}

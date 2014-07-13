function CompositeSprite_Tool::Create_Attribute_Panel(%this)
{

%Int_Y_Position=0;

%this.GuiControl_Attribute_Panel=new GuiControl()
{

Profile="Gui_Profile_Modalless";

HorizSizing="relative";

VertSizing="relative";

Position="0 0";

Extent=%this.Vector2D_Resolution;

};

%GuiControl_Panel=new GuiControl()
{

Profile="Gui_Profile_Modalless";

HorizSizing="relative";

VertSizing="relative";

Position="672 88";

Extent="128 512";

};

%this.GuiControl_Attribute_Panel.add(%GuiControl_Panel);

%GuiTextCtrl_CompositeSprite_Size=new GuiTextCtrl()
{

text="CompositeSprite Size";

maxLength="1024";

position="0 0";

extent="128 12";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextProfile";

};

%GuiControl_Panel.add(%GuiTextCtrl_CompositeSprite_Size);

%Int_Y_Position+=12;

%GuiTextEditCtrl_CompositeSprite_Size=new GuiTextEditCtrl()
{

text="800 600";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextEditProfile";

class="Class_CompositeSprite_Tool_GuiTextEditCtrl";

String_Type="CompositeSprite_Size";

};

%GuiControl_Panel.add(%GuiTextEditCtrl_CompositeSprite_Size);

%Int_Y_Position+=24;

%GuiTextCtrl_Tile_Size=new GuiTextCtrl()
{

text="Tile Size";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 12";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextProfile";

};

%GuiControl_Panel.add(%GuiTextCtrl_Tile_Size);

%Int_Y_Position+=12;

%GuiTextEditCtrl_Tile_Size=new GuiTextEditCtrl()
{

text="16 16";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextEditProfile";

class="Class_CompositeSprite_Tool_GuiTextEditCtrl";

String_Type="Tile_Size";

};

%GuiControl_Panel.add(%GuiTextEditCtrl_Tile_Size);

%Int_Y_Position+=24;

%GuiTextCtrl_Tile_Depth=new GuiTextCtrl()
{

text="Tile Depth";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 12";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextProfile";

};

%GuiControl_Panel.add(%GuiTextCtrl_Tile_Depth);

%Int_Y_Position+=12;

%GuiTextEditCtrl_Tile_Depth=new GuiTextEditCtrl()
{

text="0";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextEditProfile";

class="Class_CompositeSprite_Tool_GuiTextEditCtrl";

String_Type="Tile_Depth";

};

%GuiControl_Panel.add(%GuiTextEditCtrl_Tile_Depth);

%Int_Y_Position+=24;

%GuiTextCtrl_Tile_Animation=new GuiTextCtrl()
{

text="Tile Animation";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 12";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextProfile";

};

%GuiControl_Panel.add(%GuiTextCtrl_Tile_Animation);

%Int_Y_Position+=12;

%GuiTextEditCtrl_Tile_Animation=new GuiTextEditCtrl()
{

text="";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextEditProfile";

class="Class_CompositeSprite_Tool_GuiTextEditCtrl";

String_Type="Tile_Animation";

};

%GuiControl_Panel.add(%GuiTextEditCtrl_Tile_Animation);

%Int_Y_Position+=24;

%GuiTextCtrl_Tile_Frame=new GuiTextCtrl()
{

text="Tile Frame";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 12";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextProfile";

};

%GuiControl_Panel.add(%GuiTextCtrl_Tile_Frame);

%Int_Y_Position+=12;

%GuiTextEditCtrl_Tile_Frame=new GuiTextEditCtrl()
{

text="0";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextEditProfile";

class="Class_CompositeSprite_Tool_GuiTextEditCtrl";

String_Type="Tile_Frame";

};

%GuiControl_Panel.add(%GuiTextEditCtrl_Tile_Frame);

%Int_Y_Position+=24;

%GuiTextCtrl_Grid_Unit_Size=new GuiTextCtrl()
{

text="Grid Unit Size";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 12";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextProfile";

};

%GuiControl_Panel.add(%GuiTextCtrl_Grid_Unit_Size);

%Int_Y_Position+=12;

%GuiTextEditCtrl_Grid_Unit_Size=new GuiTextEditCtrl()
{

text="16 16";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextEditProfile";

class="Class_CompositeSprite_Tool_GuiTextEditCtrl";

String_Type="Grid_Unit_Size";

};

%GuiControl_Panel.add(%GuiTextEditCtrl_Grid_Unit_Size);

%Int_Y_Position+=24;

%GuiCheckBoxCtrl_Grid_Snap=new GuiCheckBoxCtrl()
{

text="Grid Snap";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiCheckBoxProfile";

ButtonType="ToggleButton";

class="Class_CompositeSprite_Tool_GuiCheckBoxCtrl";

String_Type="Grid_Snap";

};

%GuiCheckBoxCtrl_Grid_Snap.setStateOn(true);

%GuiControl_Panel.add(%GuiCheckBoxCtrl_Grid_Snap);

%Int_Y_Position+=24;

%GuiCheckBoxCtrl_Grid_Visible=new GuiCheckBoxCtrl()
{

text="Grid Visible";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiCheckBoxProfile";

ButtonType="ToggleButton";

class="Class_CompositeSprite_Tool_GuiCheckBoxCtrl";

String_Type="Grid_Visible";

};

%GuiCheckBoxCtrl_Grid_Visible.setStateOn(true);

%GuiControl_Panel.add(%GuiCheckBoxCtrl_Grid_Visible);

%Int_Y_Position+=24;
/*
%GuiTextCtrl_Camera_Zoom=new GuiTextCtrl()
{

text="Camera Zoom";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 12";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextProfile";

};

%GuiControl_Panel.add(%GuiTextCtrl_Camera_Zoom);

%Int_Y_Position+=12;

%GuiTextEditCtrl_Camera_Zoom=new GuiTextEditCtrl()
{

text="0";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextEditProfile";

class="Class_CompositeSprite_Tool_GuiTextEditCtrl";

String_Type="Camera_Zoom";

};

%GuiControl_Panel.add(%GuiTextEditCtrl_Camera_Zoom);

%Int_Y_Position+=24;
*/
%GuiTextCtrl_Camera_Move_Units=new GuiTextCtrl()
{

text="Camera Move Units";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 12";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextProfile";

};

%GuiControl_Panel.add(%GuiTextCtrl_Camera_Move_Units);

%Int_Y_Position+=12;

%GuiTextEditCtrl_Camera_Move_Units=new GuiTextEditCtrl()
{

text="1";

maxLength="1024";

position="0" SPC %Int_Y_Position;

extent="128 24";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextEditProfile";

class="Class_CompositeSprite_Tool_GuiTextEditCtrl";

String_Type="Camera_Move_Units";

};

%GuiControl_Panel.add(%GuiTextEditCtrl_Camera_Move_Units);

%Int_Y_Position+=24;

%GuiButtonCtrl_ULeft=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="0" SPC %Int_Y_Position;

Extent="40 24";

Text="ULeft";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="ULeft";

};

%GuiControl_Panel.add(%GuiButtonCtrl_ULeft);

%GuiButtonCtrl_Up=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="40" SPC %Int_Y_Position;

Extent="40 24";

Text="Up";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Up";

};

%GuiControl_Panel.add(%GuiButtonCtrl_Up);

%GuiButtonCtrl_URight=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="80" SPC %Int_Y_Position;

Extent="40 24";

Text="URight";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="URight";

};

%GuiControl_Panel.add(%GuiButtonCtrl_URight);

%Int_Y_Position+=24;

%GuiButtonCtrl_Left=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="0" SPC %Int_Y_Position;

Extent="40 24";

Text="Left";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Left";

};

%GuiControl_Panel.add(%GuiButtonCtrl_Left);

%GuiButtonCtrl_Right=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="80" SPC %Int_Y_Position;

Extent="40 24";

Text="Right";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Right";

};

%GuiControl_Panel.add(%GuiButtonCtrl_Right);

%Int_Y_Position+=24;

%GuiButtonCtrl_DLeft=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="0" SPC %Int_Y_Position;

Extent="40 24";

Text="DLeft";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="DLeft";

};

%GuiControl_Panel.add(%GuiButtonCtrl_DLeft);

%GuiButtonCtrl_Down=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="40" SPC %Int_Y_Position;

Extent="40 24";

Text="Down";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Down";

};

%GuiControl_Panel.add(%GuiButtonCtrl_Down);

%GuiButtonCtrl_DRight=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="80" SPC %Int_Y_Position;

Extent="40 24";

Text="DRight";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="DRight";

};

%GuiControl_Panel.add(%GuiButtonCtrl_DRight);

%Int_Y_Position+=48;

%GuiButtonCtrl_Delete=new GuiButtonCtrl()
{

Profile="BlueButtonProfile";

ButtonType="PushButton";

HorizSizing="relative";

VertSizing="relative";

Position="40" SPC %Int_Y_Position;

Extent="40 24";

Text="Delete";

class="Class_CompositeSprite_Tool_GuiButtonCtrl";

String_Type="Delete";

};

%GuiControl_Panel.add(%GuiButtonCtrl_Delete);

SandboxWindow.addGuiControl(%this.GuiControl_Attribute_Panel);

}

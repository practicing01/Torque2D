function clientCmdRegister_Map_To_Load(%Player_Name,%Module_ID_Map)
{

if (isObject(Gui_List_Previous_Text))
{

%Gui_TextCtrl=new GuiMLTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text=%Player_Name SPC "chose map" SPC %Module_ID_Map; 
Extent="200 60";
isContainer="0";
Profile="GuiTextProfile";
hovertime="1000";
MaxLength="255";
};

Gui_List_Previous_Text.add(%Gui_TextCtrl);

if (Gui_List_Previous_Text.getCount()>10)
{
Gui_List_Previous_Text.remove(Gui_List_Previous_Text.getObject(0));
}

Gui_Scroller_Previous_Text.computeSizes();

}

}

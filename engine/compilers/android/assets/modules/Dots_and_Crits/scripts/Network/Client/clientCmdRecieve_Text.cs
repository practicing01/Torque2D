function clientCmdRecieve_Text(%text)
{

if (isObject(Gui_List_Previous_Text))
{

%Gui_ScrollCtrl=new GuiScrollCtrl()
{

canSaveDynamicFields="1";
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Extent="200 60";
isContainer="1";
Profile="GuiLightScrollProfile";
hScrollBar="dynamic";
vScrollBar="dynamic";
childMargin="2 3";

};

%Gui_TextCtrl=new GuiMLTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text=%text; 
Extent="200 60";
isContainer="1";
Profile="GuiTextProfile";
hovertime="1000";
MaxLength="255";
};

%Gui_ScrollCtrl.add(%Gui_TextCtrl);

Gui_List_Previous_Text.add(%Gui_ScrollCtrl);

if (Gui_List_Previous_Text.getCount()>10)
{
Gui_List_Previous_Text.remove(Gui_List_Previous_Text.getObject(0));
}

Gui_Scroller_Previous_Text.computeSizes();

Gui_Scroller_Previous_Text.scrollToBottom();

%Gui_ScrollCtrl.computeSizes();

%Gui_ScrollCtrl.setScrollPosition(0,0);

}

}

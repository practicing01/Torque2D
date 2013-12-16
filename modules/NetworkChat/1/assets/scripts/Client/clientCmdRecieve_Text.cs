function clientCmdRecieve_Text(%text)
{

//make text object, add to list
%gui_textcontrol=new GuiTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text=%text; 
Extent="200 20";
isContainer="0";
Profile="GuiTextProfile";
hovertime="1000";
MaxLength="512";
};

gui_list_previoustext.add(%gui_textcontrol);

if (gui_list_previoustext.getCount()>10)
{
gui_list_previoustext.remove(gui_list_previoustext.getObject(0));
}

gui_scroller_previoustext.computeSizes();

}

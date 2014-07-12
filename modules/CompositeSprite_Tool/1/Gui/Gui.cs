if (!isObject(Gui_Profile_Modalless))
{

new GuiControlProfile(Gui_Profile_Modalless)
{

modal=false;

border="0";

};

}

if (!isObject(Gui_List_Profile_Colored))
{

new GuiControlProfile(Gui_List_Profile_Colored)
{

tab=true;

canKeyFocus=true;

fontColor="255 255 255 255";

fillColor="128 128 128 128";

};

}

exec("./File_Toolbar.cs");
exec("./Image_Ribbon.cs");
exec("./Attribute_Panel.cs");


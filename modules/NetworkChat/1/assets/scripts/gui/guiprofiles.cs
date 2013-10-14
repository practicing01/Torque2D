if (!isObject(gui_list_profile_colored))
{
new GuiControlProfile(gui_list_profile_colored)
{
tab=true;
canKeyFocus=true;
fontColor="255 255 255 255";
fillColor="128 128 128 128";
};
}

if (!isObject(gui_profile_modalless))
{
new GuiControlProfile(gui_profile_modalless)
{
modal=false;
border="0";
};
}

if (!isObject(GuiRadioProfileColored))
{
new GuiControlProfile (GuiRadioProfileColored:GuiRadioProfile)
{
fontColor="255 255 255 255";
};
}

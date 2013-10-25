function Module_Player_Sprite_Ayn::Gui_Menu_Config_Populate_Animations(%this)
{

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.clearItems();

if (%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.getSelectedItem()==-1){return;}

%this.Gui_List_Menu_Config_Selection_Simset=%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.getSelectedItem();

%Script_Object_Player_Sprite=%this.Gui_Menu_Config.Composite_Sprite_Player_Parent.Script_Object_Parent;

%String_Selected_Simset=%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.getItemText
(
%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.getSelectedItem()
);

if (%String_Selected_Simset$="Stand Up Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Stand Up Right Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Right.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Right.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Stand Right Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Right.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Right.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Stand Down Right Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Right.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Right.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Stand Down Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Stand Down Left Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Left.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Left.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Stand Left Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Left.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Left.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Stand Up Left Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Left.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Left.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Run Up Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Run Up Right Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Right.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Right.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Run Right Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Right.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Right.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Run Down Right Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Right.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Right.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Run Down Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Run Down Left Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Left.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Left.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Run Left Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Left.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Left.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}
else if (%String_Selected_Simset$="Run Up Left Emote")
{

for (%x=0;%x<%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Left.getCount();%x++)
{

%Object=%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Left.getObject(%x);

%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.addItem(%Object.String_Animation_Name);

}

}

}

function Module_Player_Sprite_Ayn::Gui_Menu_Config_Set_Animation(%this)
{

if (%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.getSelectedItem()==-1){return;}

%Script_Object_Player_Sprite=%this.Gui_Menu_Config.Composite_Sprite_Player_Parent.Script_Object_Parent;

%UInt_Selected_Animation=%this.Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects.getSelectedItem();

if (%this.Gui_List_Menu_Config_Selection_Simset==0)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==1)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Right.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==2)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Right.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==3)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Right.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==4)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==5)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Down_Left.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==6)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Left.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==7)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Stand_Emote_Up_Left.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==8)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==9)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Right.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==10)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Right.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==11)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Right.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==12)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==13)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Down_Left.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==14)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Left.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}
else if (%this.Gui_List_Menu_Config_Selection_Simset==15)
{

%Script_Object_Player_Sprite.Asset_ID_Animation_Emote=
%Script_Object_Player_Sprite.Simset_Animation_Run_Emote_Up_Left.getObject(%UInt_Selected_Animation).Asset_ID_Animation;

}

}

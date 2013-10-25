function Module_Player_Sprite_Ayn::Gui_Menu_Create(%this,%Composite_Sprite_Player)
{

//--- OBJECT WRITE BEGIN ---
%Gui_Menu=new GuiControl() {
   canSaveDynamicFields = "1";
   isContainer = "1";
   Profile = "gui_profile_modalless";
   HorizSizing = "relative";
   VertSizing = "relative";
   Position = "0 0";
   Extent = "800 480";
   MinExtent = "1 1";
   canSave = "1";
   Visible = "1";
   Active = "0";
   tooltipWidth = "250";
   hovertime = "1000";
   
   Bool_Delete_Me="1";

   new GuiButtonCtrl() {
      canSaveDynamicFields = "1";
      isContainer = "0";
      Profile = "BlueButtonProfile";
      HorizSizing = "relative";
      VertSizing = "relative";
      Position = "350 215";
      Extent = "50 25";
      MinExtent = "1 1";
      canSave = "1";
      Visible = "1";
      Active = "1";
      tooltipWidth = "250";
      hovertime = "1000";
      text = "Move";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Player_Sprite_Ayn_Gui_Menu";
      
      String_Action="Move";
      
      Composite_Sprite_Player_Parent=%Composite_Sprite_Player;
      
   };
   new GuiButtonCtrl() {
      canSaveDynamicFields = "1";
      isContainer = "0";
      Profile = "BlueButtonProfile";
      HorizSizing = "relative";
      VertSizing = "relative";
      Position = "400 215";
      Extent = "50 25";
      MinExtent = "1 1";
      canSave = "1";
      Visible = "1";
      Active = "1";
      tooltipWidth = "250";
      hovertime = "1000";
      text = "Attack";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Player_Sprite_Ayn_Gui_Menu";
      
      String_Action="Attack";
      
      Composite_Sprite_Player_Parent=%Composite_Sprite_Player;
      
   };
   new GuiButtonCtrl() {
      canSaveDynamicFields = "1";
      isContainer = "0";
      Profile = "BlueButtonProfile";
      HorizSizing = "relative";
      VertSizing = "relative";
      Position = "400 240";
      Extent = "50 25";
      MinExtent = "1 1";
      canSave = "1";
      Visible = "1";
      Active = "1";
      tooltipWidth = "250";
      hovertime = "1000";
      text = "Emote";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Player_Sprite_Ayn_Gui_Menu";
      
      String_Action="Emote";
      
      Composite_Sprite_Player_Parent=%Composite_Sprite_Player;
      
   };
   new GuiButtonCtrl() {
      canSaveDynamicFields = "1";
      isContainer = "0";
      Profile = "BlueButtonProfile";
      HorizSizing = "relative";
      VertSizing = "relative";
      Position = "350 240";
      Extent = "50 25";
      MinExtent = "1 1";
      canSave = "1";
      Visible = "1";
      Active = "1";
      tooltipWidth = "250";
      hovertime = "1000";
      text = "Config";
      groupNum = "-1";
      buttonType = "PushButton";
      useMouseEvents = "1";
      
      Bool_Delete_Me="1";
      
      class="Module_Player_Sprite_Ayn_Gui_Menu";
      
      String_Action="Config";
      
      Composite_Sprite_Player_Parent=%Composite_Sprite_Player;
      
   };
};
//--- OBJECT WRITE END ---

return %Gui_Menu;

}

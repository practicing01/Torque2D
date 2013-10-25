function Module_Player_Sprite_Ayn::Gui_Menu_Config_Create(%this,%Composite_Sprite_Player_Parent)
{

%Script_Object_Player_Sprite=%Composite_Sprite_Player_Parent.Script_Object_Parent;

   %Gui_Menu_Config=new GuiWindowCtrl() {
      canSaveDynamicFields = "1";
      isContainer = "1";
      Profile = "GuiDefaultProfile";
      HorizSizing = "relative";
      VertSizing = "relative";
      Position = ($Resolution.X/2)-200 SPC ($Resolution.Y/2)-110;
      Extent = "400 220";
      MinExtent = "1 1";
      canSave = "1";
      Visible = "1";
      Active = "1";
      tooltipWidth = "250";
      hovertime = "1000";
      canMove="1";
      canClose="1";
      canMaximize="0";
      canMinimize="0";
      resizeHeight="0";
      resizeWidth="0";
      class="Module_Player_Sprite_Ayn_Gui_Menu_Config";
      
      closeCommand="Module_Player_Sprite_Ayn.Gui_Menu_Config_Close();";
      
      Gui_Scroller_Ayn_Menu_Config_Simsets=0;
      
      Gui_Scroller_Ayn_Menu_Config_Objects=0;
      
      Bool_Delete_Me="1";
      
      Composite_Sprite_Player_Parent=%Composite_Sprite_Player_Parent;
      
   };
   
%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets=new GuiScrollCtrl() {
			canSaveDynamicFields="1";
			isContainer="1";
			Profile="GuiLightScrollProfile";
			HorizSizing="relative";
			VertSizing="relative";
			Position="0 20";
			Extent="200 200";
			MinExtent="1 1";
			canSave="1";
			Visible="1";
			Active="1";
			hovertime="1000";
			willFirstRespond="1";
			hScrollBar="dynamic";
			vScrollBar="dynamic";
			constantThumbHeight="0";
			childMargin="2 3";
			
         Bool_Delete_Me="1";

			Gui_List_Ayn_Menu_Config_Simsets=0;
			
         };

%Gui_Menu_Config.add(%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets);

			
%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets=new GuiListBoxCtrl(){
					Profile="gui_list_profile_colored";
					isContainer="0";
					HorizSizing="relative";
					VertSizing="relative";
					Position="0 0";
					Extent="200 200";
					MinExtent="1 1";
					canSave="1";
					Visible="1";
					Active="1";
					AllowMultipleSelections="0";
					
               AltCommand="Module_Player_Sprite_Ayn.Gui_Menu_Config_Simsets_Double_Click();";
					
               Bool_Delete_Me="1";
               
				};

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.add(%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets);

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects=new GuiScrollCtrl() {
			canSaveDynamicFields="1";
			isContainer="1";
			Profile="GuiLightScrollProfile";
			HorizSizing="relative";
			VertSizing="relative";
			Position="200 20";
			Extent="200 200";
			MinExtent="1 1";
			canSave="1";
			Visible="1";
			Active="1";
			hovertime="1000";
			willFirstRespond="1";
			hScrollBar="dynamic";
			vScrollBar="dynamic";
			constantThumbHeight="0";
			childMargin="2 3";
			
         Bool_Delete_Me="1";

			Gui_List_Ayn_Menu_Config_Objects=0;
			
         };

%Gui_Menu_Config.add(%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects);

			
%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects=new GuiListBoxCtrl(){
					Profile="gui_list_profile_colored";
					command="";
					isContainer="0";
					HorizSizing="relative";
					VertSizing="relative";
					Position="0 0";
					Extent="200 200";
					MinExtent="1 1";
					canSave="1";
					Visible="1";
					Active="1";
					AllowMultipleSelections="0";
					
               AltCommand="Module_Player_Sprite_Ayn.Gui_Menu_Config_Objects_Double_Click();";
					
               Bool_Delete_Me="1";
               
				};
				
%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.add(%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Objects.Gui_List_Ayn_Menu_Config_Objects);

/*************************************************************/

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Stand Up Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Stand Up Right Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Stand Right Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Stand Down Right Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Stand Down Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Stand Down Left Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Stand Left Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Stand Up Left Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Run Up Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Run Up Right Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Run Right Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Run Down Right Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Run Down Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Run Down Left Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Run Left Emote");

%Gui_Menu_Config.Gui_Scroller_Ayn_Menu_Config_Simsets.Gui_List_Ayn_Menu_Config_Simsets.addItem("Run Up Left Emote");

/*************************************************************/

return %Gui_Menu_Config;

}

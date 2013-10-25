function Module_Player_Sprite_Ayn::Gui_Button_Gui_Menu_Attack(%this,%Vector_2D_World_Point)
{

//Need to mod this in the future to pick for npcs and dwo's

%String_List_Picked_Objects=Scene_Dots_and_Crits.pickPoint(%Vector_2D_World_Point,bit(0),"","collision");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

//Get first object.

%Object=getWord(%String_List_Picked_Objects,0);

commandToServer('Relay_Module_Function',Module_Player_Sprite_Ayn,"Action_Attack",
%Object.Module_ID_Parent,%Object.Script_Object_Parent.Game_Connection_Handle);

}

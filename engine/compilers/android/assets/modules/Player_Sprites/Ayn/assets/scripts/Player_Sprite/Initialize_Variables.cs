function Module_Player_Sprite_Ayn::Initialize_Variables(%this)
{

/*Will hold each players Script_Object_Player_Sprite.*/
/*This will be used to identify which object called an rpc.*/

%this.Simset_Player_Information=new SimSet();

%this.Bool_Waiting_For_Move=false;

%this.Bool_Waiting_For_Attack=false;

%this.Gui_Menu_Config=0;

%this.Gui_List_Menu_Config_Selection_Simset=-1;

}

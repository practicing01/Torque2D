function Splashes::Main_Menu_Load(%this)
{

ModuleDatabase.LoadExplicit("Module_Gui_Main_Menu");
Module_Gui_Main_Menu.Scene_Load();

}

function Splashes::Splash_Logo_Torque(%this)
{

Scene_Dots_and_Crits.clear();

alxPlay("Splashes:audio_torquewrench");

%Sprite_Logo_Torque=new Sprite()
{
Position="0 0";
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Logo_Torque);
Image="Splashes:Image_Logo_Torque";
BodyType="static";
};

Scene_Dots_and_Crits.add(%Sprite_Logo_Torque);

%this.Scene_Unload();

schedule(3000,0,"Splashes::Main_Menu_Load",%this);

}

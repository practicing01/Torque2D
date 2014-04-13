function Phyxel_Editor::Variables_Initialize( %this )
{

%this.Vector_2D_Resolution=getRes();

%this.Vector_2D_Camera_Size=SandboxWindow.getCameraSize();

%this.Vector_2D_Grid_Size="32 32";

%this.Vector_4D_Phyxel_Color="1.0 1.0 1.0 1.0";

/*************************************

Edit Modes:

0=color;
1=toggle enabling/disabling of phyxel.
2=distance joint object picking
3=toggle squiggler
4=weld joint object picking

*************************************/
%this.Int_Edit_Mode=0;

%this.Script_Object_Input_Controller=0;

%this.Sprite_Joint_Object_A=0;

%this.Sprite_Joint_Object_B=0;

%this.Joint_Distance_Frequency=0.5;

%this.Joint_Distance_Damping_Ratio=0.5;

%this.SimSet_Grid_Phyxels=0;

%this.Bool_Squiggle=false;

}

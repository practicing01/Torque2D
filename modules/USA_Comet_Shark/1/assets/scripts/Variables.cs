function USA_Comet_Shark::Initialize_Variables(%this)
{

%this.SimSet_States=new SimSet();

%this.SimSet_States_Remaining=new SimSet();

%this.SimSet_Positions=0;

%this.Sprite_Shark=0;

%this.Gui_Target_State=0;

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_USA_Comet_Shark_Input_Controller";

};

SandboxWindow.addInputListener(%this.Script_Object_Input_Controller);

}

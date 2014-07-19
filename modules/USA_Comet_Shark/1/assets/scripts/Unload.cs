function USA_Comet_Shark::Unload(%this)
{

if (isObject(%this.SimSet_States))
{

%this.SimSet_States.deleteObjects();

%this.SimSet_States.delete();

}

if (isObject(%this.SimSet_States_Remaining))
{

%this.SimSet_States_Remaining.deleteObjects();

%this.SimSet_States_Remaining.delete();

}

if (isObject(%this.SimSet_Positions))
{

%this.SimSet_Positions.deleteObjects();

%this.SimSet_Positions.delete();

}

if (isObject(%this.Script_Object_Input_Controller))
{

SandboxWindow.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

}

if (isObject(%this.Gui_Target_State))
{

if (SandboxWindow.isMember(%this.Gui_Target_State))
{

SandboxWindow.remove(%this.Gui_Target_State);

}

%this.Gui_Target_State.delete();

}

}

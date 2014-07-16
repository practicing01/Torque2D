function USA_Comet_Shark::Generate_Target_State(%this)
{

if (isObject(%this.Gui_Target_State))
{

if (SandboxWindow.isMember(%this.Gui_Target_State))
{

SandboxWindow.remove(%this.Gui_Target_State);

}

%this.Gui_Target_State.delete();

}

%ScriptObject_State=0;

if (%this.SimSet_States_Remaining.getCount())
{

%ScriptObject_State=%this.SimSet_States_Remaining.getObject(getRandom(0,%this.SimSet_States_Remaining.getCount()-1));

}

%String_State="Fin";

if (isObject(%ScriptObject_State))
{

%String_State=%ScriptObject_State.String_State;

}

%Vector_2D_Position=SandboxWindow.getWindowExtents().Z*0.5 SPC 0;

%this.Gui_Target_State=new GuiTextCtrl()
{

text=%String_State;

maxLength="1024";

position=%Vector_2D_Position;

extent="128 12";

HorizSizing="relative";

VertSizing="relative";

profile="GuiTextProfile";

};

SandboxWindow.add(%this.Gui_Target_State);

}

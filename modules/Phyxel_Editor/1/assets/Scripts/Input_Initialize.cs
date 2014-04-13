function Phyxel_Editor::Input_Initialize( %this )
{

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Phyxel_Editor_Input_Controller";

Module_ID_Parent=%this;

};

SandboxWindow.addInputListener(%this.Script_Object_Input_Controller);

}

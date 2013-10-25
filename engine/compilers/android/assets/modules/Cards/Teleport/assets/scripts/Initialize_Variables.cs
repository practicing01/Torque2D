function Module_Card_Teleport::Initialize_Variables(%this)
{

%this.Bool_Waiting_For_Target=false;

%this.Card_Target=0;

%this.Bool_Waiting_For_Cast=false;

%this.Scene_Object_Input_Capture=new SceneObject()
{

BodyType="static";
Position="0 0";
size="1 1";
class="Scene_Object_Module_Card_Teleport_Input_Capture";
canSaveDynamicFields="1";

Module_ID_Parent=%this;

};

%this.Scene_Object_Input_Capture.setUseInputEvents(true);
Window_Dots_and_Crits.addInputListener(%this.Scene_Object_Input_Capture);

Scene_Dots_and_Crits.add(%this.Scene_Object_Input_Capture);

}

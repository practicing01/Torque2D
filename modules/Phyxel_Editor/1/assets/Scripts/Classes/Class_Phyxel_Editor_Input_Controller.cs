function Class_Phyxel_Editor_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

%String_List_Picked_Objects=SandboxScene.pickPoint(%Vector_2D_World_Position,"","","any");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

if (%this.Module_ID_Parent.Int_Edit_Mode==0)//Color.
{

%Object.setBlendColor(%this.Module_ID_Parent.Vector_4D_Phyxel_Color);

}
else if (%this.Module_ID_Parent.Int_Edit_Mode==1)//Toggle phyxel.
{

%Object.Bool_Is_Phyxel=!%Object.Bool_Is_Phyxel;


if (%Object.Bool_Is_Phyxel)
{

%Object.SceneLayer=16;

}
else
{

%Object.SceneLayer=17;

%Object.Bool_Is_Squiggler=false;

}

}
else if (%this.Module_ID_Parent.Int_Edit_Mode==3)//Toggle squiggler.
{

%Object.Bool_Is_Squiggler=!%Object.Bool_Is_Squiggler;

%Object.Bool_Is_Phyxel=true;

if (%Object.Bool_Is_Squiggler)
{

%Object.SceneLayer=15;

}
else
{

%Object.SceneLayer=16;

}

}
else if (%this.Module_ID_Parent.Int_Edit_Mode==5)//Toggle heavy.
{

if (%Object.DefaultDensity==0)
{

%Object.DefaultDensity=1000;

}
else
{

%Object.DefaultDensity=0;

}

%Object.DefaultRestitution=!%Object.DefaultRestitution;

}
else if (%this.Module_ID_Parent.Int_Edit_Mode==2)//Distance joint picking.
{

if (%this.Module_ID_Parent.Sprite_Joint_Object_A==0)
{

%this.Module_ID_Parent.Sprite_Joint_Object_A=%Object;

}
else if (%this.Module_ID_Parent.Sprite_Joint_Object_B==0&&(%this.Module_ID_Parent.Sprite_Joint_Object_A!=%Object))
{

%this.Module_ID_Parent.Sprite_Joint_Object_B=%Object;

SandboxScene.createDistanceJoint(%this.Module_ID_Parent.Sprite_Joint_Object_A,%this.Module_ID_Parent.Sprite_Joint_Object_B,"0 0","0 0",
Vector2Distance(%this.Module_ID_Parent.Sprite_Joint_Object_A.Position,%this.Module_ID_Parent.Sprite_Joint_Object_B.Position),
%this.Module_ID_Parent.Joint_Distance_Frequency,
%this.Module_ID_Parent.Joint_Distance_Damping_Ratio,
true);//false);

/*Store joint connection in object A only.*/

%ScriptObject_Connected_Phyxel_Grid_Position=new ScriptObject()
{

Vector_2D_Grid_Position=%this.Module_ID_Parent.Sprite_Joint_Object_B.Vector_2D_Grid_Position;

};

%this.Module_ID_Parent.Sprite_Joint_Object_A.SimSet_Distance_Joint_Connections.add(%ScriptObject_Connected_Phyxel_Grid_Position);

%this.Module_ID_Parent.Sprite_Joint_Object_A=0;

%this.Module_ID_Parent.Sprite_Joint_Object_B=0;

}

}
else if (%this.Module_ID_Parent.Int_Edit_Mode==4)//Weld joint picking.
{

if (%this.Module_ID_Parent.Sprite_Joint_Object_A==0)
{

%this.Module_ID_Parent.Sprite_Joint_Object_A=%Object;

}
else if (%this.Module_ID_Parent.Sprite_Joint_Object_B==0&&(%this.Module_ID_Parent.Sprite_Joint_Object_A!=%Object))
{

%this.Module_ID_Parent.Sprite_Joint_Object_B=%Object;

/*SandboxScene.createWeldJoint(%this.Module_ID_Parent.Sprite_Joint_Object_A,%this.Module_ID_Parent.Sprite_Joint_Object_B,
"0 0",
"0 0",
0,
0,
false);*/

SandboxScene.createWeldJoint(%this.Module_ID_Parent.Sprite_Joint_Object_A,%this.Module_ID_Parent.Sprite_Joint_Object_B,
%this.Module_ID_Parent.Sprite_Joint_Object_A.getLocalVector(%this.Module_ID_Parent.Sprite_Joint_Object_B.Position),
%this.Module_ID_Parent.Sprite_Joint_Object_B.getLocalVector(%this.Module_ID_Parent.Sprite_Joint_Object_A.Position),
0,//%this.Module_ID_Parent.Joint_Distance_Frequency,
1,//%this.Module_ID_Parent.Joint_Distance_Damping_Ratio,
false);

/*Store joint connection in object A only.*/

%ScriptObject_Connected_Phyxel_Grid_Position=new ScriptObject()
{

Vector_2D_Grid_Position=%this.Module_ID_Parent.Sprite_Joint_Object_B.Vector_2D_Grid_Position;

};

%this.Module_ID_Parent.Sprite_Joint_Object_A.SimSet_Weld_Joint_Connections.add(%ScriptObject_Connected_Phyxel_Grid_Position);

%this.Module_ID_Parent.Sprite_Joint_Object_A=0;

%this.Module_ID_Parent.Sprite_Joint_Object_B=0;

}

}

return;//First object for now.

}

}

function Class_Phyxel_Editor_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{



}

function Class_Phyxel_Editor_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{

if (%this.Module_ID_Parent.Int_Edit_Mode!=0){return;}

%String_List_Picked_Objects=SandboxScene.pickPoint(%Vector_2D_World_Position,"","","any");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

%Object.setBlendColor(%this.Module_ID_Parent.Vector_4D_Phyxel_Color);

return;//First object for now.

}

}

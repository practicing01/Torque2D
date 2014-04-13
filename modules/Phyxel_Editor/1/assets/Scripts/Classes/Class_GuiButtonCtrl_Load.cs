function Class_GuiButtonCtrl_Load::onAction(%this)
{

%FileObject_File=new FileStreamObject();

%FileObject_File.open("./../../../Phyxel.txt","Read");

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Grid_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.Module_ID_Parent.SimSet_Grid_Phyxels.getObject(%x);

%Sprite_Phyxel.Size=%FileObject_File.readLine();
echo("%Sprite_Phyxel.Size" SPC %Sprite_Phyxel.Size);

%Sprite_Phyxel.BlendColor=%FileObject_File.readLine();
echo("%Sprite_Phyxel.BlendColor" SPC %Sprite_Phyxel.BlendColor);

%Sprite_Phyxel.Vector_2D_Origin=%FileObject_File.readLine();
echo("%Sprite_Phyxel.Vector_2D_Origin" SPC %Sprite_Phyxel.Vector_2D_Origin);

%Sprite_Phyxel.Vector_2D_Original_Size=%FileObject_File.readLine();
echo("%Sprite_Phyxel.Vector_2D_Original_Size" SPC %Sprite_Phyxel.Vector_2D_Original_Size);

%Sprite_Phyxel.SceneLayer=%FileObject_File.readLine();
echo("%Sprite_Phyxel.SceneLayer" SPC %Sprite_Phyxel.SceneLayer);

%Sprite_Phyxel.Bool_Is_Phyxel=%FileObject_File.readLine();
echo("%Sprite_Phyxel.Bool_Is_Phyxel" SPC %Sprite_Phyxel.Bool_Is_Phyxel);

%Sprite_Phyxel.Bool_Is_Squiggler=%FileObject_File.readLine();
echo("%Sprite_Phyxel.Bool_Is_Squiggler" SPC %Sprite_Phyxel.Bool_Is_Squiggler);

%Sprite_Phyxel.DefaultDensity=%FileObject_File.readLine();
echo("%Sprite_Phyxel.DefaultDensity" SPC %Sprite_Phyxel.DefaultDensity);

%Sprite_Phyxel.DefaultRestitution=%FileObject_File.readLine();
echo("%Sprite_Phyxel.DefaultRestitution" SPC %Sprite_Phyxel.DefaultRestitution);

%Sprite_Phyxel.Vector_2D_Grid_Position=%FileObject_File.readLine();
echo("%Sprite_Phyxel.Vector_2D_Grid_Position" SPC %Sprite_Phyxel.Vector_2D_Grid_Position);

%Int_Distance_Joint_Connection_Count=%FileObject_File.readLine();
echo("%Int_Distance_Joint_Connection_Count" SPC %Int_Distance_Joint_Connection_Count);

for (%y=0;%y<%Int_Distance_Joint_Connection_Count;%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=new ScriptObject()
{

Vector_2D_Grid_Position=%FileObject_File.readLine();

};
echo("Vector_2D_Grid_Position" SPC Vector_2D_Grid_Position);

%Sprite_Phyxel.SimSet_Distance_Joint_Connections.add(%ScriptObject_Connected_Phyxel_Grid_Position);

}

%Int_Weld_Joint_Connection_Count=%FileObject_File.readLine();
echo("%Int_Weld_Joint_Connection_Count" SPC %Int_Weld_Joint_Connection_Count);

for (%y=0;%y<%Int_Weld_Joint_Connection_Count;%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=new ScriptObject()
{

Vector_2D_Grid_Position=%FileObject_File.readLine();

};
echo("Vector_2D_Grid_Position" SPC Vector_2D_Grid_Position);

%Sprite_Phyxel.SimSet_Weld_Joint_Connections.add(%ScriptObject_Connected_Phyxel_Grid_Position);

}

}

%FileObject_File.close();

/*Make joint connections*/

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Grid_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.Module_ID_Parent.SimSet_Grid_Phyxels.getObject(%x);

//banana
//%Sprite_Phyxel.SimSet_Distance_Joint_Connections.deleteObjects();
//%Sprite_Phyxel.SimSet_Weld_Joint_Connections.deleteObjects();continue;

for (%y=0;%y<%Sprite_Phyxel.SimSet_Distance_Joint_Connections.getCount();%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=%Sprite_Phyxel.SimSet_Distance_Joint_Connections.getObject(%y);

%Sprite_Connected_Phyxel=%this.Module_ID_Parent.SimSet_Grid_Phyxels.getObject(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.X+
(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.Y*%this.Module_ID_Parent.Vector_2D_Grid_Size.Y));

SandboxScene.createDistanceJoint(%Sprite_Phyxel,%Sprite_Connected_Phyxel,"0 0","0 0",
Vector2Distance(%Sprite_Phyxel.Position,%Sprite_Connected_Phyxel.Position),
%this.Module_ID_Parent.Joint_Distance_Frequency,
%this.Module_ID_Parent.Joint_Distance_Damping_Ratio,
true);//false);

}

for (%y=0;%y<%Sprite_Phyxel.SimSet_Weld_Joint_Connections.getCount();%y++)
{

%ScriptObject_Connected_Phyxel_Grid_Position=%Sprite_Phyxel.SimSet_Weld_Joint_Connections.getObject(%y);

%Sprite_Connected_Phyxel=%this.Module_ID_Parent.SimSet_Grid_Phyxels.getObject(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.X+
(%ScriptObject_Connected_Phyxel_Grid_Position.Vector_2D_Grid_Position.Y*%this.Module_ID_Parent.Vector_2D_Grid_Size.Y));

SandboxScene.createWeldJoint(%Sprite_Phyxel,%Sprite_Connected_Phyxel,
%Sprite_Phyxel.getLocalVector(%Sprite_Connected_Phyxel.Position),
%Sprite_Connected_Phyxel.getLocalVector(%Sprite_Phyxel.Position),
0,//%this.Module_ID_Parent.Joint_Distance_Frequency,
1,//%this.Module_ID_Parent.Joint_Distance_Damping_Ratio,
false);

}

}

}

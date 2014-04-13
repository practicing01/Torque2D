function Class_GuiButtonCtrl_Save::onAction(%this)
{

%FileObject_File_Out=new FileObject();

%FileObject_File_Out.openForWrite("./../../../Phyxel.txt");

for (%x=0;%x<%this.Module_ID_Parent.SimSet_Grid_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.Module_ID_Parent.SimSet_Grid_Phyxels.getObject(%x);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.Size);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.BlendColor);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.Vector_2D_Origin);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.Vector_2D_Original_Size);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.SceneLayer);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.Bool_Is_Phyxel);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.Bool_Is_Squiggler);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.DefaultDensity);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.DefaultRestitution);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.Vector_2D_Grid_Position);

%FileObject_File_Out.writeLine(%Sprite_Phyxel.SimSet_Distance_Joint_Connections.getCount());

for (%y=0;%y<%Sprite_Phyxel.SimSet_Distance_Joint_Connections.getCount();%y++)
{

%FileObject_File_Out.writeLine(%Sprite_Phyxel.SimSet_Distance_Joint_Connections.getObject(%y).Vector_2D_Grid_Position);

}

%FileObject_File_Out.writeLine(%Sprite_Phyxel.SimSet_Weld_Joint_Connections.getCount());

for (%y=0;%y<%Sprite_Phyxel.SimSet_Weld_Joint_Connections.getCount();%y++)
{

%FileObject_File_Out.writeLine(%Sprite_Phyxel.SimSet_Weld_Joint_Connections.getObject(%y).Vector_2D_Grid_Position);

}

}

%FileObject_File_Out.close();

}

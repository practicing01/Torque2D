function Class_GuiTextEditCtrl_Color::onReturn(%this)
{

if (%this.color$="Red")
{

%this.Module_ID_Parent.Vector_4D_Phyxel_Color.X=%this.getText();

}
else if (%this.color$="Green")
{

%this.Module_ID_Parent.Vector_4D_Phyxel_Color.Y=%this.getText();

}
else if (%this.color$="Blue")
{

%this.Module_ID_Parent.Vector_4D_Phyxel_Color.Z=%this.getText();

}
else if (%this.color$="Alpha")
{

%this.Module_ID_Parent.Vector_4D_Phyxel_Color.W=%this.getText();

}

%this.setActive(false);

%this.setActive(true);

}

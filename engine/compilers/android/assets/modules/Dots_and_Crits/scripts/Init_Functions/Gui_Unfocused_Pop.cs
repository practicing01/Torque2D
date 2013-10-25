function Dots_and_Crits::Gui_Unfocused_Pop(%this)
{

for (%x=0;%x<$Simset_Unfocused_Guis_To_Pop.getCount();%x++)
{

%Gui_Object=$Simset_Unfocused_Guis_To_Pop.getObject(%x);

Canvas.popDialog(%Gui_Object);

}

$Simset_Unfocused_Guis_To_Pop.clear();

}

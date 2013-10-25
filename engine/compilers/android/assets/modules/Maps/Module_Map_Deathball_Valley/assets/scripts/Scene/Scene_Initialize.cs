function Module_Map_Deathball_Valley::Scene_Initialize(%this)
{

echo("Deathball Valley initialized.");

%this.Gui_Scroll_Arrows_Spawn();

for (%x=0;%x<Scene_Dots_and_Crits.getCount();%x++)
{

%Object=Scene_Dots_and_Crits.getObject(%x);

if (%Object.class$="Class_Portal_Spawn")
{

%this.Simset_Portal_Spawn.add(%Object);

}

}

}

exec("./Load_Map.cs");
exec("./Load_Player_Data.cs");
exec("./Load_Cards.cs");

function Dots_and_Crits::Load_Play(%this)
{

%this.Load_Map();

%this.Load_Player_Data();

%this.Load_Cards();

//Scene_Dots_and_Crits.setDebugOn("joints");
//Scene_Dots_and_Crits.setDebugOn("metrics");
//Scene_Dots_and_Crits.setDebugOn("fps");
//Scene_Dots_and_Crits.setDebugOn("wireframe");
//Scene_Dots_and_Crits.setDebugOn("aabb");
//Scene_Dots_and_Crits.setDebugOn("oobb");
//Scene_Dots_and_Crits.setDebugOn("sleep");
//Scene_Dots_and_Crits.setDebugOn("collision");
//Scene_Dots_and_Crits.setDebugOn("position");
//Scene_Dots_and_Crits.setDebugOn("sort");
//Scene_Dots_and_Crits.setDebugOn("controllers");

}

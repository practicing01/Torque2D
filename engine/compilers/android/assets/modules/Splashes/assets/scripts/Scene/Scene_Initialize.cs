exec("./../Dove/Dove_Construct.cs");
exec("./../Dove/onCollision.cs");
exec("./../Torque/Splash_Logo_Torque.cs");

function Splashes::Scene_Initialize(%this)
{

%this.Bool_Company_Name_Displayed=false;

%this.Dove_Construct();

Scene_Dots_and_Crits.setGravity(0,-50);//so the dove drops

}

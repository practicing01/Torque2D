exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Initialize_Variables.cs");
exec("./Player_Data/Player_Data.cs");
exec("./Player_Class_Initialize.cs");
exec("./Input_Touch/Input_Touch.cs");
exec("./Movement/onMoveToComplete.cs");

function Module_Player_Class::Player_Class_Load(%this)
{

%this.Ass_Load();

%this.Initialize_Variables();

%this.Player_Class_Initialize();

}

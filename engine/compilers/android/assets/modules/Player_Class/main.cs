function Module_Player_Class::create(%this)
{

exec("./assets/scripts/Player_Class_Load.cs");
exec("./assets/scripts/Player_Class_Unload.cs");

}

function Module_Player_Class::destroy(%this)
{

%this.Player_Class_Unload();

}

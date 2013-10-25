function Dots_and_Crits::Load_Map(%this)
{

for (%x=0;%x<$Simset_ModuleID_Maps.getCount();%x++)
{

%Object=$Simset_ModuleID_Maps.getObject(%x);

if (%Object.String_Description$=$String_Map_To_Load)
{

ModuleDatabase.LoadExplicit(%Object.Module_ID_Map);

%Object.Module_ID_Map.Scene_Load();

$Module_ID_Map_Loaded=%Object.Module_ID_Map;

return;

}

}

}

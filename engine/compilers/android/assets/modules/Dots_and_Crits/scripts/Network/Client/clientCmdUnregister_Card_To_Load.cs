function clientCmdUnregister_Card_To_Load(%Module_ID_Card)
{

if (!isObject($Simset_Cards_To_Load)){return;}

for (%x=0;%x<$Simset_Cards_To_Load.getCount();%x++)
{

%Script_Object_Card=$Simset_Cards_To_Load.getObject(%x);

if (%Script_Object_Card.Module_ID_Card$=%Module_ID_Card)
{

$Simset_Cards_To_Load.remove(%Script_Object_Card);

%Script_Object_Card.delete();

}

}

}

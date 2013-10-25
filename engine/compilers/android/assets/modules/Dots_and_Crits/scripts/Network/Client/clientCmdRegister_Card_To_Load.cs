function clientCmdRegister_Card_To_Load(%Module_ID_Card)
{

if (!isObject($Simset_Cards_To_Load)){return;}

%Script_Object=new ScriptObject()
{

Module_ID_Card=%Module_ID_Card;

};

$Simset_Cards_To_Load.add(%Script_Object);

}

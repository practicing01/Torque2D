struct Struct_Module_Banana_Main
{

int Int_Counter;

};

struct Struct_Module_Banana_Main* Machine_Banana_Create();

void Machine_Banana_Destroy(struct Struct_Module_Banana_Main*);

void Machine_Banana_Process(struct Struct_Module_Banana_Main*);

extern struct Struct_Module_Banana_Main *Struct_Module_Banana_Main_This;

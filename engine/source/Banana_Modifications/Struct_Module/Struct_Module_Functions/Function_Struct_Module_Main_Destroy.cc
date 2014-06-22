void Function_Struct_Module_Main_Destroy(struct Struct_Module *Pointer_Struct_Module)
{

/******************************************************************************/

if (*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents)!=NULL)
{

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)(*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents));

unsigned int *Pointer_Struct_Module_Linked_List_Node_Next;

do
{

Pointer_Struct_Module_Linked_List_Node_Next=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

free(Pointer_Struct_Module_Linked_List_Node);

Pointer_Struct_Module_Linked_List_Node=Pointer_Struct_Module_Linked_List_Node_Next;

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));

}

/******************************************************************************/

if (*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children)!=NULL)
{

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)(*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children));

unsigned int *Pointer_Struct_Module_Linked_List_Node_Next;

struct Struct_Module *Pointer_Struct_Module_Cast_Linked_List_Node=NULL;

do
{

Pointer_Struct_Module_Linked_List_Node_Next=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

Pointer_Struct_Module_Cast_Linked_List_Node=
(struct Struct_Module *)(*(Pointer_Struct_Module_Linked_List_Node+2));

Pointer_Struct_Module_Cast_Linked_List_Node->Pointer_Function_Destroy(Pointer_Struct_Module_Cast_Linked_List_Node);

free(Pointer_Struct_Module_Linked_List_Node);

Pointer_Struct_Module_Linked_List_Node=Pointer_Struct_Module_Linked_List_Node_Next;

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));

}

/******************************************************************************/

/*if (*(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data)!=NULL)
{

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)(*(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data));

unsigned int *Pointer_Struct_Module_Linked_List_Node_Next;

do
{

Pointer_Struct_Module_Linked_List_Node_Next=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

free(Pointer_Struct_Module_Linked_List_Node);

Pointer_Struct_Module_Linked_List_Node=Pointer_Struct_Module_Linked_List_Node_Next;

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));

}*/

/******************************************************************************/

free(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents);

free(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children);

//free(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data);

free(Pointer_Struct_Module->Pointer_Char_Array_Identifier);

free(Pointer_Struct_Module);

}

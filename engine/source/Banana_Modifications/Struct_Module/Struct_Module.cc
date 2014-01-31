//Modular Banana by practicing01

#ifndef _CONSOLE_H_
#include "console/console.h"
#endif

#include <string.h>
#include "Struct_Module.h"

struct Struct_Module *Pointer_Struct_Module_Main=NULL;

struct Struct_Module*  Function_Struct_Module_Main_Create()
{

struct Struct_Module *Struct_Module_Node=(struct Struct_Module*)malloc(sizeof(struct Struct_Module));

return Struct_Module_Node;

}

void Function_Struct_Module_Main_Destroy(struct Struct_Module *Pointer_Struct_Module)
{

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

do
{

Pointer_Struct_Module_Linked_List_Node_Next=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

free(Pointer_Struct_Module_Linked_List_Node);

Pointer_Struct_Module_Linked_List_Node=Pointer_Struct_Module_Linked_List_Node_Next;

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));

}

/******************************************************************************/

free(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents);

free(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children);

free(Pointer_Struct_Module->Pointer_Char_Array_Identifier);

free(Pointer_Struct_Module);

}

void Function_Struct_Module_Main_Link(struct Struct_Module *Pointer_Struct_Module_Parent,
struct Struct_Module *Pointer_Struct_Module_Child)
{

/*

Linked list format:

{First_Node, Last_Node}

Node format:

{Node_Previous, Node_Next, Data}

*/

//New linked list.
if (*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children)==NULL)
{

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)malloc((sizeof(unsigned int)*2)+sizeof(struct Struct_Module *));

*(Pointer_Struct_Module_Linked_List_Node)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Linked_List_Node+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Linked_List_Node+2)=(unsigned int)Pointer_Struct_Module_Child;

*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children)=
(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children+1)=
(unsigned int)Pointer_Struct_Module_Linked_List_Node;

}
else
{

unsigned int *Pointer_Struct_Module_Linked_List_Node_Penultimate=
(unsigned int*)(*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children+1));

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)malloc((sizeof(unsigned int)*2)+sizeof(struct Struct_Module *));

*(Pointer_Struct_Module_Linked_List_Node_Penultimate+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Linked_List_Node)=(unsigned int)Pointer_Struct_Module_Linked_List_Node_Penultimate;

*(Pointer_Struct_Module_Linked_List_Node+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Linked_List_Node+2)=(unsigned int)Pointer_Struct_Module_Child;

*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children+1)=
(unsigned int)Pointer_Struct_Module_Linked_List_Node;

}

/****************************************************************************************/

if (*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents)==NULL)
{

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)malloc((sizeof(unsigned int)*2)+sizeof(struct Struct_Module *));

*(Pointer_Struct_Module_Linked_List_Node)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Linked_List_Node+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Linked_List_Node+2)=(unsigned int)Pointer_Struct_Module_Parent;

*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents)=
(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents+1)=
(unsigned int)Pointer_Struct_Module_Linked_List_Node;

}
else
{

unsigned int *Pointer_Struct_Module_Linked_List_Node_Penultimate=
(unsigned int*)(*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents+1));

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)malloc((sizeof(unsigned int)*2)+sizeof(struct Struct_Module *));

*(Pointer_Struct_Module_Linked_List_Node_Penultimate+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Linked_List_Node)=(unsigned int)Pointer_Struct_Module_Linked_List_Node_Penultimate;

*(Pointer_Struct_Module_Linked_List_Node+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

*(Pointer_Struct_Module_Linked_List_Node+2)=(unsigned int)Pointer_Struct_Module_Parent;

*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents+1)=
(unsigned int)Pointer_Struct_Module_Linked_List_Node;

}

}

void Function_Struct_Module_Main_Loop(struct Struct_Module *Pointer_Struct_Module)
{

Con::printf("Loop Struct_Module %d Int_Counter=%d\n",Pointer_Struct_Module,
Pointer_Struct_Module->Int_Counter);

Pointer_Struct_Module->Int_Counter++;

if (Pointer_Struct_Module->Int_Counter<100){return;}

if (*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children)==NULL)
{

return;

}

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)(*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children));

struct Struct_Module *Pointer_Struct_Module_Cast_Linked_List_Node=
(struct Struct_Module *)(*(Pointer_Struct_Module_Linked_List_Node+2));

do
{

Pointer_Struct_Module_Cast_Linked_List_Node->Pointer_Function_Loop(Pointer_Struct_Module_Cast_Linked_List_Node);

Pointer_Struct_Module_Linked_List_Node=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));

}

void Function_Struct_Module_Main_Initialize(struct Struct_Module *Pointer_Struct_Module)
{

Pointer_Struct_Module->Int_Counter=0;

Pointer_Struct_Module->Bool_Loop=1;

char *Pointer_Char_Array_Identifier=(char *)malloc(sizeof(char)*512);

memset(Pointer_Char_Array_Identifier,NULL,512);

char Char_Array_Identifier[]="Module_Main";

memcpy(Pointer_Char_Array_Identifier,Char_Array_Identifier,sizeof(Char_Array_Identifier));

Pointer_Struct_Module->Pointer_Char_Array_Identifier=Pointer_Char_Array_Identifier;

Pointer_Struct_Module->Int_Size_Identifier=sizeof(Char_Array_Identifier);

Pointer_Struct_Module->Pointer_Function_Create=Function_Struct_Module_Main_Create;

Pointer_Struct_Module->Pointer_Function_Initialize=Function_Struct_Module_Main_Initialize;

Pointer_Struct_Module->Pointer_Function_Destroy=Function_Struct_Module_Main_Destroy;

Pointer_Struct_Module->Pointer_Function_Link=Function_Struct_Module_Main_Link;

Pointer_Struct_Module->Pointer_Function_Loop=Function_Struct_Module_Main_Loop;

/******************************************************************************/

Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents=
(unsigned int*)malloc((sizeof(unsigned int)*2));

*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents)=NULL;

*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents+1)=NULL;

Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children=
(unsigned int*)malloc((sizeof(unsigned int*)*2));

*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children)=NULL;

*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children+1)=NULL;

/******************************************************************************/

}

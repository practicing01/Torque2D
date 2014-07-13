function CompositeSprite_Tool::Pick_For_Deletion(%this,%Vector_2D_World_Position)
{

%String_SpriteIDs=%this.CompositeSprite_Level.pickArea(%Vector_2D_World_Position,Vector2Add(%Vector_2D_World_Position,"0.1 0.1"));

if (getWordCount(%String_SpriteIDs)==0){return;}
else if (getWordCount(%String_SpriteIDs)==1)
{

%SpriteID=getWord(%String_SpriteIDs,0);

%this.CompositeSprite_Level.selectSpriteId(%SpriteID);

%this.CompositeSprite_Level.removeSprite();

return;

}


%this.SimSet_Picked_Object_List.clear();

%this.GuiControl_Object_List.GuiListBoxCtrl_Object_List.clearItems();

for (%x=0;%x<getWordCount(%String_SpriteIDs);%x++)
{

%SpriteID=getWord(%String_SpriteIDs,%x);

%ScriptObject_SpriteID=new ScriptObject()
{

SpriteID=%SpriteID;

};

%this.SimSet_Picked_Object_List.add(%ScriptObject_SpriteID);

%this.GuiControl_Object_List.GuiListBoxCtrl_Object_List.addItem(%SpriteID);

}

%this.GuiControl_Object_List.Position=SandboxWindow.getWindowPoint(%Vector_2D_World_Position);

SandboxWindow.add(%this.GuiControl_Object_List);

}

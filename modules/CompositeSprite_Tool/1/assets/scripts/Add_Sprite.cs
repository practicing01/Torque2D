function CompositeSprite_Tool::Add_Sprite(%this,%Vector_2D_World_Position)
{

if (%this.String_Selected_Image$=""){return;}

%Vector_2D_Tile_Size=Vector2Mult(%this.Tile_Size,%this.Camera_World_Scale);

if (!%this.Bool_Grid_Snap)
{

%this.CompositeSprite_Level.addSprite();

%this.CompositeSprite_Level.setSpriteLocalPosition(%Vector_2D_World_Position);

%this.CompositeSprite_Level.setSpriteSize(%Vector_2D_Tile_Size);

%this.CompositeSprite_Level.setSpriteImage(%this.String_Selected_Image);

%this.CompositeSprite_Level.setSpriteDepth(%this.Tile_Depth);

if (%this.String_Tile_Animation!$="")
{

%this.CompositeSprite_Level.setSpriteAnimation(%this.String_Tile_Animation);

}

}
else
{

%String_SpriteIDs=%this.CompositeSprite_Grid.pickArea(%Vector_2D_World_Position,Vector2Add(%Vector_2D_World_Position,"0.1 0.1"));

if (getWordCount(%String_SpriteIDs)==0){return;}

%SpriteID=getWord(%String_SpriteIDs,0);

%this.CompositeSprite_Grid.selectSpriteId(%SpriteID);

%Vector_2D_Local_Position=%this.CompositeSprite_Grid.getSpriteLocalPosition();

%Vector_2D_World_Position=%this.CompositeSprite_Grid.getWorldVector(%Vector_2D_Local_Position);

%this.CompositeSprite_Level.addSprite();

%this.CompositeSprite_Level.setSpriteLocalPosition(%Vector_2D_World_Position);

%this.CompositeSprite_Level.setSpriteSize(%Vector_2D_Tile_Size);

%this.CompositeSprite_Level.setSpriteImage(%this.String_Selected_Image);

%this.CompositeSprite_Level.setSpriteDepth(%this.Tile_Depth);

if (%this.String_Tile_Animation!$="")
{

%this.CompositeSprite_Level.setSpriteAnimation(%this.String_Tile_Animation);

}

}

}

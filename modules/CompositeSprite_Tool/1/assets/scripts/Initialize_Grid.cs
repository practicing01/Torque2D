function CompositeSprite_Tool::Initialize_Grid(%this)
{

if (isObject(%this.CompositeSprite_Grid))
{

%this.CompositeSprite_Grid.clearSprites();

}
else
{

%this.CompositeSprite_Grid=new CompositeSprite()
{

SceneLayer=0;

BodyType="static";

PickingAllowed=false;

Position="0 0";

};

}

%this.CompositeSprite_Grid.SetBatchLayout("off");

%this.CompositeSprite_Grid.SetBatchSortMode("z");

%this.CompositeSprite_Grid.SetBatchIsolated(true);

SandboxScene.add(%this.CompositeSprite_Grid);

%Vector_2D_Scaled_Grid_Unit_Size=Vector2Mult(%this.Grid_Unit_Size,%this.Camera_World_Scale);

%Vector_2D_Scaled_Grid_Unit_Size_Half=Vector2Mult(%this.Grid_Unit_Size,"0.5 0.5");

%Vector_2D_CompositeSprite_Size_Half=Vector2Mult(%this.CompositeSprite_Size,"0.5 0.5");

%Vector_2D_CompositeSprite_Size_Half=Vector2Mult(%Vector_2D_CompositeSprite_Size_Half,%this.Camera_World_Scale);

%Vector_2D_CompositeSprite_Size_Half=Vector2Add(%Vector_2D_CompositeSprite_Size_Half,%Vector_2D_Scaled_Grid_Unit_Size_Half);

for (%y=0;%y<%this.CompositeSprite_Size.Y;%y+=%this.Grid_Unit_Size.Y)
{

for (%x=0;%x<%this.CompositeSprite_Size.X;%x+=%this.Grid_Unit_Size.X)
{

%Vector_2D_Position=Vector2Mult(%x SPC %y,%this.Camera_World_Scale);

//%Vector_2D_Position=Vector2Add(%Vector_2D_Position,Vector2Mult(%x SPC %y,%Vector_2D_CompositeSprite_Size_Half));

%this.CompositeSprite_Grid.addSprite();

%this.CompositeSprite_Grid.setSpriteLocalPosition(%Vector_2D_Position);

%this.CompositeSprite_Grid.setSpriteSize(%Vector_2D_Scaled_Grid_Unit_Size);

%this.CompositeSprite_Grid.setSpriteImage("CompositeSprite_Tool:Image_Grid_Highlighted_Tile");

%this.CompositeSprite_Grid.setSpriteBlendAlpha(0.15);

}

}

}

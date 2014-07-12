//-----------------------------------------------------------------------------
// Copyright (c) 2013 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

function CompositeSprite_Tool::create( %this )
{

    //Variables
    %this.String_Filename="Filename.txt";

    %this.Vector2D_Resolution=getRes();

    %this.Camera_World_Scale=SandboxWindow.getCameraWorldScale();

    %this.GuiControl_File_Toolbar=0;

    %this.GuiControl_Image_Ribbon=0;

    %this.GuiControl_Attribute_Panel=0;

    %this.String_Selected_Image="";

    %this.String_Tile_Animation="";

    %this.CompositeSprite_Level=0;

    %this.CompositeSprite_Grid=0;

    %this.CompositeSprite_Size="800 600";

    %this.Tile_Size="16 16";

    %this.Tile_Depth="0";

    %this.Grid_Unit_Size="16 16";

    %this.Bool_Grid_Snap=true;

    %this.Camera_Zoom="0";

    %this.Camera_Move_Units="1";
    
    %this.Bool_Moving_Camera=false;

    %this.Script_Object_Input_Controller=new ScriptObject()
    {

        class="Class_CompositeSprite_Tool_Input_Controller";

        Vector_2D_Previous_Position="0 0";

    };

    SandboxWindow.addInputListener(%this.Script_Object_Input_Controller);

    //Load gui.
    exec("./Gui/Gui.cs");

    %this.Create_File_Toolbar();

    %this.Create_Image_Ribbon();

    %this.Create_Attribute_Panel();

    //Load classes.
    exec("./Classes/Classes.cs");

    //Load scripts.
    exec("./assets/scripts/scripts.cs");

    // Reset the toy.
    CompositeSprite_Tool.reset();

}

//-----------------------------------------------------------------------------

function CompositeSprite_Tool::destroy( %this )
{

    if (isObject(%this.GuiControl_File_Toolbar))
    {

        SandboxWindow.remove(%this.GuiControl_File_Toolbar);

    }

    if (isObject(%this.GuiControl_Image_Ribbon))
    {

        SandboxWindow.remove(%this.GuiControl_Image_Ribbon);

    }

    if (isObject(%this.GuiControl_Attribute_Panel))
    {

        SandboxWindow.remove(%this.GuiControl_Attribute_Panel);

    }

    if (isObject(%this.Script_Object_Input_Controller))
    {

        SandboxWindow.removeInputListener(%this.Script_Object_Input_Controller);

        %this.Script_Object_Input_Controller.delete();

    }

}

//-----------------------------------------------------------------------------

function CompositeSprite_Tool::reset( %this )
{
    // Clear the scene.
    SandboxScene.clear();

    %this.SceneObject_Camera=new SceneObject()
    {

        Position="0 0";

        PickingAllowed=false;

    };

    SandboxScene.add(%this.SceneObject_Camera);

    SandboxWindow.mount(%this.SceneObject_Camera);

    //Initial CompositeSprite.
    %this.Initialize_CompositeSprite();

    //Initial grid.
    %this.Initialize_Grid();

}

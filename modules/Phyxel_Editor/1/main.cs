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

function Phyxel_Editor::reset( %this )
{

// Clear the scene.
SandboxScene.clear();

exec("./assets/Scripts/Variables_Initialize.cs");

exec("./assets/Scripts/Scale_To_Camera.cs");

exec("./assets/Scripts/Grid_Initialize.cs");

exec("./assets/Scripts/Gui_Initialize.cs");

exec("./assets/Scripts/Classes/Classes.cs");

exec("./assets/Scripts/Input_Initialize.cs");

SandboxWindow.setCameraPosition("0 0");

%this.Variables_Initialize();

%this.Grid_Initialize();

%this.Gui_Initialize();

%this.Input_Initialize();

}

//-----------------------------------------------------------------------------

function Phyxel_Editor::create( %this )
{

// Reset the toy.    
Phyxel_Editor.reset();
    
}

//-----------------------------------------------------------------------------

function Phyxel_Editor::destroy( %this )
{

for (%x=0;%x<%this.SimSet_Grid_Phyxels.getCount();%x++)
{

%Sprite_Phyxel=%this.SimSet_Grid_Phyxels.getObject(%x);

%Sprite_Phyxel.SimSet_Distance_Joint_Connections.delete();

%Sprite_Phyxel.SimSet_Weld_Joint_Connections.delete();

}

%this.SimSet_Grid_Phyxels.delete();

%this.GuiWindowCtrl_Tool_Window.deleteObjects();

%this.GuiWindowCtrl_Tool_Window.delete();

SandboxWindow.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

}

//-----------------------------------------------------------------------------

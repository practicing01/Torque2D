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

function USA_Comet_Shark::create( %this )
{


exec("./assets/scripts/scripts.cs");

    // Reset the toy.    
    USA_Comet_Shark.reset();

}

//-----------------------------------------------------------------------------

function USA_Comet_Shark::destroy( %this )
{

%this.Unload();

}

//-----------------------------------------------------------------------------

function USA_Comet_Shark::reset( %this )
{
    // Clear the scene.
    SandboxScene.clear();

%this.Initialize_Variables();

%this.Load_Star_Field();

%this.Enumerate_States();

%this.Create_States();

%this.Create_Shark();

%this.Generate_Target_State();

}

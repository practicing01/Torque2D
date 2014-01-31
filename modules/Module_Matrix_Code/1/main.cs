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

function Module_Matrix_Code::create( %this )
{

%this.Ass_Image_Font=AssetDatabase.acquireAsset("ToyAssets:Font");

    // Reset the toy.    
    Module_Matrix_Code.reset();
}

//-----------------------------------------------------------------------------

function Module_Matrix_Code::destroy( %this )
{

AssetDatabase.releaseAsset(%this.Ass_Image_Font.getAssetId());

}

//-----------------------------------------------------------------------------

function Module_Matrix_Code::Column_Generate(%this,%Vector_2D_Spawn,%Float_X_Interval)
{

%Float_Y_Interval=(%this.Vector_2D_Camera_Size.Y*%Float_X_Interval)/%this.Vector_2D_Camera_Size.X;

%Float_Column_Size_Y_Start=getRandomf(%this.Vector_2D_Camera_Size_Half.Y,%this.Vector_2D_Camera_Size.Y*0.75);

%Float_Column_Size_Y_End=getRandomf(%Float_Column_Size_Y_Start,%this.Vector_2D_Camera_Size.Y*1.75);

%Float_Column_Size_Y_End_Half=%Float_Column_Size_Y_End/2;

%Bool_Found_Spawner=false;

%Vector_4D_Color="0.75 1 0.5 1";

%Int_Velocity=getRandom(10,15);

for (%y=%Float_Column_Size_Y_Start-(%Float_Y_Interval*0.5);%y<%Float_Column_Size_Y_End;%y+=%Float_Y_Interval)
{

%Image_Font_Character=new ImageFont()
{

Position=%Vector_2D_Spawn.X SPC %y;
Image="ToyAssets:Font";
FontSize=%Float_X_Interval SPC %Float_Y_Interval;
TextAlignment="Center";
BodyType="dynamic";
class="Class_Matrix_Code_Character";
FixedAngle=true;
BlendColor=%Vector_4D_Color;

Bool_Is_Spawner=false;

Vector_2D_Spawn=%Vector_2D_Spawn;

Module_Parent=%this;

Schedule_Randomize_Char=0;

};

if (%y>=%Float_Column_Size_Y_End_Half&&!%Bool_Found_Spawner)
{

%Image_Font_Character.Bool_Is_Spawner=true;

%Bool_Found_Spawner=true;//Because I can't math.

}

%Int_Character_Index=getRandom(0,%this.Char_Array_Characters_Length);

%Image_Font_Character.Text=getSubStr(%this.Char_Array_Characters,%Int_Character_Index,1);

SandboxScene.add(%Image_Font_Character);

%Vector_2D_Destination=%Image_Font_Character.Position.X SPC -%this.Vector_2D_Camera_Size_Half.Y;

%Image_Font_Character.moveTo(%Vector_2D_Destination,%Int_Velocity,true,true);

%Vector_4D_Color="0.25 1 0.25 0.75";

%Image_Font_Character.Schedule_Randomize_Char=schedule(getRandom(1000,3000),0,"Class_Matrix_Code_Character::Schedule_Randomize_Char",%Image_Font_Character);

}

}

//-----------------------------------------------------------------------------

function Class_Matrix_Code_Character::onMoveToComplete(%this)
{

if (%this.Bool_Is_Spawner)
{

%this.Module_Parent.Column_Generate(%this.Vector_2D_Spawn,%this.FontSize.X);

}

%this.safeDelete();

}

//-----------------------------------------------------------------------------

function Class_Matrix_Code_Character::Schedule_Randomize_Char(%this)
{

%this.Text=getSubStr(%this.Module_Parent.Char_Array_Characters,getRandom(0,%this.Module_Parent.Char_Array_Characters_Length),1);

%this.Schedule_Randomize_Char=schedule(getRandom(1000,3000),0,"Class_Matrix_Code_Character::Schedule_Randomize_Char",%this);

}

//-----------------------------------------------------------------------------

function Module_Matrix_Code::reset( %this )
{
    // Clear the scene.
    SandboxScene.clear();

SandboxWindow.setCameraPosition("0 0");

SandboxWindow.setCameraZoom(1);

%this.Char_Array_Characters=" !#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`~abcdefghijklmnopqrstuvwxyz";

%this.Char_Array_Characters_Length=strlen(%this.Char_Array_Characters)-1;

%this.Vector_2D_Camera_Size=SandboxWindow.getCameraSize();

%this.Vector_2D_Camera_Size_Half=%this.Vector_2D_Camera_Size.X/2 SPC %this.Vector_2D_Camera_Size.Y/2;

%this.Int_Column_Count=40;

%Float_X_Interval=%this.Vector_2D_Camera_Size.X/%this.Int_Column_Count;

for (%x=(-(%this.Vector_2D_Camera_Size_Half.X))+(%Float_X_Interval*0.5);%x<%this.Vector_2D_Camera_Size_Half.X;%x+=%Float_X_Interval)
{

%this.Column_Generate(%x SPC %this.Vector_2D_Camera_Size_Half.Y,%Float_X_Interval);

}

 
}


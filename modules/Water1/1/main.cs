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

function Water1::create( %this )
{

%this.causticass=AssetDatabase.acquireAsset("Water1:image_caustics");

%this.upmoveschedule=0;
%this.downmoveschedule=0;
%this.leftmoveschedule=0;
%this.rightmoveschedule=0;

    // Reset the toy.    
    Water1.reset();
    
}

//-----------------------------------------------------------------------------

function Water1::destroy( %this )
{

AssetDatabase.releaseAsset(%this.causticass.getAssetId());

%this.simset_caustictiles.delete();

cancel(%this.upmoveschedule);
cancel(%this.downmoveschedule);
cancel(%this.leftmoveschedule);
cancel(%this.rightmoveschedule);

}

//-----------------------------------------------------------------------------

function Water1::reset( %this )
{
    // Clear the scene.
    SandboxScene.clear();
    
    exec("./scaletocam.cs");
    exec("./movewater.cs");
    exec("./Color_Randomize.cs");

GlobalActionMap.bindCmd(keyboard,"w","Water1.movewater(0,1);","Water1.movewater(0,0);");
GlobalActionMap.bindCmd(keyboard,"s","Water1.movewater(1,1);","Water1.movewater(1,0);");
GlobalActionMap.bindCmd(keyboard,"a","Water1.movewater(2,1);","Water1.movewater(2,0);");
GlobalActionMap.bindCmd(keyboard,"d","Water1.movewater(3,1);","Water1.movewater(3,0);");


$resolution=$pref::Video::defaultResolution;
$camsize=SandboxWindow.getCameraSize();

%watercolorass=AssetDatabase.acquireAsset("Water1:image_watercolor");

%this.watercolor=new Sprite()
{
Position="0 0";
Size=ScaleAssSizeVectorToCam(%watercolorass);
Image="Water1:image_watercolor";
SceneLayer=16;
BodyType="static";
BlendColor="0 0 0";
};
SandboxScene.add(%this.watercolor);

AssetDatabase.releaseAsset(%watercolorass.getAssetId());

//%this.Color_Randomize();

%this.simset_caustictiles=new SimSet();


for (%y=-%this.causticass.getCellHeight()/2;%y<$resolution.Y+(%this.causticass.getCellHeight());%y+=%this.causticass.getCellHeight())
{
for (%x=-%this.causticass.getCellWidth()/2;%x<$resolution.X+(%this.causticass.getCellWidth());%x+=%this.causticass.getCellWidth())
{

%tile=new Sprite()
{
Position=ScalePositionVectorToCam(%x SPC %y);
Size=ScaleAssSizeVectorToCam(%this.causticass);
Image="Water1:image_caustics";
SceneLayer=15;
BodyType="static";
BlendColor="1.0 1.0 1.0 0.5";
};
SandboxScene.add(%tile);

%tile.playAnimation("Water1:anim_caustics");

%this.simset_caustictiles.add(%tile);

}
}

    // Create the image font.
    %object = new ImageFont();
    
    // Always try to configure a scene-object prior to adding it to a scene for best performance.
    
    // Set the image font to use the font image asset.
    %object.Image = "ToyAssets:Font";
    
    // We don't really need to do this as the position is set to zero by default.
    %object.Position = "0 0";
    
    // We don't need to size this object as it sizes automatically according to the alignment, font-size and text.
   
    // Set the font size in both axis.  This is in world-units and not typicaly font "points".
    %object.FontSize = "2 2";
    
    // We don't really need to do this as the padding is set to zero by default.
    // Padding is specified in world-units and relates to the space added between each character.
    %object.FontPadding = 0;

    // Set the text alignment.
    %object.TextAlignment = "Center";

    // Set the text to display.
    %object.Text = "Keys: wasd";

    // Make the text spin just to make it more interesting!
    %object.AngularVelocity = 30;
    
    // The ImageFont is a type that defaults to a "static" body-type (typically so it's not affected by gravity)
    // but we want this to spin so we need a "dynamic" body-type/
    %object.BodyType = "dynamic";
    
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}

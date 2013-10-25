function Window_Create_Dots_and_Crits()
{

if (!isObject(Window_Dots_and_Crits))
{

new SceneWindow(Window_Dots_and_Crits);   

Window_Dots_and_Crits.Profile=Gui_Profile_Window_Dots_and_Crits;

Canvas.setContent(Window_Dots_and_Crits);                     

}

Window_Dots_and_Crits.stopCameraMove();
Window_Dots_and_Crits.dismount();
Window_Dots_and_Crits.setViewLimitOff();
Window_Dots_and_Crits.setRenderGroups($All_Bits);
Window_Dots_and_Crits.setRenderLayers($All_Bits);
Window_Dots_and_Crits.setObjectInputEventGroupFilter($All_Bits);
Window_Dots_and_Crits.setObjectInputEventLayerFilter($All_Bits);
Window_Dots_and_Crits.setLockMouse(true);
Window_Dots_and_Crits.setCameraPosition(0,0);
Window_Dots_and_Crits.setCameraZoom(1);
Window_Dots_and_Crits.setCameraAngle(0);

$Resolution=getRes();
%Y_Times_100=100*$Resolution.Y;
%Cam_Y=%Y_Times_100/$Resolution.X;

Window_Dots_and_Crits.setCameraSize(100,%Cam_Y);

}

//-----------------------------------------------------------------------------

function Window_Destroy_Dots_and_Crits()
{
    
if (isObject(Window_Dots_and_Crits))
{

Window_Dots_and_Crits.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Dots_and_Crits()
{

if (isObject(Scene_Dots_and_Crits))
{

Cancel_All_Schedules();

Scene_Dots_and_Crits.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Dots_and_Crits))
{

error("Cannot set Dots_and_Crits Scene to Window as the Scene is invalid.");
return;

}
    
Window_Dots_and_Crits.setScene(Scene_Dots_and_Crits);

Window_Dots_and_Crits.stopCameraMove();
Window_Dots_and_Crits.dismount();
Window_Dots_and_Crits.setViewLimitOff();
Window_Dots_and_Crits.setRenderGroups($All_Bits);
Window_Dots_and_Crits.setRenderLayers($All_Bits);
Window_Dots_and_Crits.setObjectInputEventGroupFilter($All_Bits);
Window_Dots_and_Crits.setObjectInputEventLayerFilter($All_Bits);
Window_Dots_and_Crits.setLockMouse(true);
Window_Dots_and_Crits.setCameraPosition(0,0);
Window_Dots_and_Crits.setCameraZoom(1);
Window_Dots_and_Crits.setCameraAngle(0);

$Resolution=getRes();
%Y_Times_100=100*$Resolution.Y;
%Cam_Y=%Y_Times_100/$Resolution.X;

Window_Dots_and_Crits.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Dots_and_Crits()
{

Scene_Destroy_Dots_and_Crits();

new Scene(Scene_Dots_and_Crits);

if (!isObject(Window_Dots_and_Crits))
{

error("Dots_and_Crits: Created scene but no window available.");
return;

}

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Dots_and_Crits to use an invalid Scene.");
return;

}
   
Scene_Destroy_Dots_and_Crits();

%Scene.setName("Scene_Dots_and_Crits");    

Scene_Set_To_Window();

}

//-----------------------------------------------------------------------------

function Scene_Dots_and_Crits::onCollision(%this, %sceneObjectA, %sceneObjectB, %collisionDetails)
{
    if (%sceneObjectA.isMethod(handleCollision))
        %sceneObjectA.handleCollision(%sceneObjectB, %collisionDetails);
    else
        %sceneObjectA.callOnBehaviors(handleCollision, %sceneObjectB, %collisionDetails);

    if (%sceneObjectB.isMethod(handleCollision))
        %sceneObjectB.handleCollision(%sceneObjectA, %collisionDetails);
    else
        %sceneObjectB.callOnBehaviors(handleCollision, %sceneObjectA, %collisionDetails);
}

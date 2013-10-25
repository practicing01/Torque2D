function Module_Card_Flashlight::Action_Cast(%this,%Player_Information,%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=0;

for (%x=0;%x<Module_Player_Class.Simset_Player_Data.getCount();%x++)
{

%Player_Object=Module_Player_Class.Simset_Player_Data.getObject(%x);

if (%Player_Object.Game_Connection_Handle==%Player_Sprite_Target_Game_Connection_Handle)
{

%Target_Player=%Player_Object;

break;

}

}

if (%Target_Player==0){return;}

//Use player info to play animations.

%Player_Object=0;

for (%x=0;%x<%this.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%Target_Player.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)//New Flashlight user.
{

%Script_Object_Player_Information=new ScriptObject()
{

Player_Information=%Target_Player;

Sprite_Flashlight=0;

};

%Vector_2D_Flashlight_Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Flashlight);

%Script_Object_Player_Information.Sprite_Flashlight=new Sprite()
{

BodyType="static";
size=%Vector_2D_Flashlight_Size;
Image="Module_Card_Flashlight:Image_Flashlight";
Position="0 0";
SrcBlendFactor="SRC_ALPHA";
DstBlendFactor="DST_ALPHA";
BlendMode=true;

};

%this.Simset_Player_Information.add(%Script_Object_Player_Information);

Scene_Dots_and_Crits.add(%Script_Object_Player_Information.Sprite_Flashlight);

%Vector_2D_Player_Size=%Target_Player.Player_Sprite_Data.Composite_Sprite.getSpriteSize();

%Vector_2D_Mount_Offset="0 0";

%Vector_2D_Mount_Offset.Y=(%Vector_2D_Player_Size.Y/2)+(%Vector_2D_Flashlight_Size.Y/2);

%Script_Object_Player_Information.Sprite_Flashlight.mount(%Target_Player.Player_Sprite_Data.Scene_Object_Mount,%Vector_2D_Mount_Offset,0,true,mDegToRad(0));

}
else
{

if (%Player_Object.Sprite_Flashlight.Visible)
{

%Player_Object.Sprite_Flashlight.Visible=false;

}
else
{

%Player_Object.Sprite_Flashlight.Visible=true;

}

}

}

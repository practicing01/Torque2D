function Class_Dove_Bodypart::onCollision(%this,%object,%collisionDetails)
{

if (%this.class$=%object.class){return;}

if (!%this.Handle_Module_Parent.Bool_Company_Name_Displayed)
{

%this.Handle_Module_Parent.Bool_Company_Name_Displayed=true;

%Sprite_Company_Name=new Sprite()
{
Size=Scale_Ass_Size_Vector_To_Camera(%this.Handle_Module_Parent.Ass_Name);
Image="Splashes:Image_Name";
BodyType="static";
};

%Sprite_Company_Name.Position=%this.Position.X SPC %this.Position.Y-
( (%this.Size.Y/2) + (%Sprite_Company_Name.Size.Y/2) );

Scene_Dots_and_Crits.add(%Sprite_Company_Name);

schedule(3000,0,"Splashes::Splash_Logo_Torque",%this.Handle_Module_Parent);

}

}

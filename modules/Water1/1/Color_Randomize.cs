function Water1::Color_Randomize(%this)
{

%rand=getRandom(0,2);
%value=-0.1;

if (getRandom(0,1))
{
%value=0.1;
}

if (%rand==0)
{

%this.watercolor.setBlendColor(%this.watercolor.BlendColor.X+%value,%this.watercolor.BlendColor.Y,%this.watercolor.BlendColor.Z);

}
else if (%rand==1)
{

%this.watercolor.setBlendColor(%this.watercolor.BlendColor.X,%this.watercolor.BlendColor.Y+%value,%this.watercolor.BlendColor.Z);

}
else
{

%this.watercolor.setBlendColor(%this.watercolor.BlendColor.X,%this.watercolor.BlendColor.Y,%this.watercolor.BlendColor.Z+%value);

}

schedule(25,0,"Water1::Color_Randomize",%this);
}

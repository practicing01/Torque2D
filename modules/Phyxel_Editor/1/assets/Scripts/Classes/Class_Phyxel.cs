function Class_Phyxel::Squiggle(%this)
{

if (!isObject(%this)){return;}

/*%Float_Scale_X=getRandomF(-1,1);

%Float_Scale_Y=getRandomF(-1,1);

%this.Size.X+=%Float_Scale_X;

%this.Size.Y+=%Float_Scale_Y;

if (%this.Size.X>%this.Vector_2D_Original_Size.X*2)
{

%this.Size.X=%this.Vector_2D_Original_Size.X*2;

}
else if (%this.Size.X<=0)
{

%this.Size.X=0.1;

}

if (%this.Size.Y>%this.Vector_2D_Original_Size.Y*2)
{

%this.Size.Y=%this.Vector_2D_Original_Size.Y*2;

}
else if (%this.Size.Y<=0)
{

%this.Size.Y=0.1;

}*/

%this.setLinearVelocityPolar(getRandom(0,360),5);

%this.Schedule_Squiggle=schedule(62,0,"Class_Phyxel::Squiggle",%this);

}

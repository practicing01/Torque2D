function Scale_Ass_Size_Vector_To_Camera(%Ass)
{

%Size="0 0";

if (%Ass.getCellWidth()==0)
{

%Size=%Ass.getImageSize();

}
else
{

%Size.X=%Ass.getCellWidth();
%Size.Y=%Ass.getCellHeight();

}

if (%Ass.Optimal_Resolution)
{

%Size.X=(%Size.X*$Resolution.X)/%Ass.Optimal_Resolution.X;
%Size.Y=(%Size.Y*$Resolution.Y)/%Ass.Optimal_Resolution.Y;

}
else{echo("Warning: Optimal_Resolution Asset Field Not Found.");}

%Size.X=(%Size.X*$Camera_Size.X)/$Resolution.X;
%Size.Y=(%Size.Y*$Camera_Size.Y)/$Resolution.Y;

return %Size;

}

function Scale_Position_Vector_To_Camera(%Vector_2D)//assumes that x=0=left, y=0=top and +y=down, -y=up
{

%Vector_2D_Scaled=%Vector_2D;
%Vector_2D_Scaled.X-=$Resolution.X/2;//offset cus cam is from -50 to 50
%Vector_2D_Scaled.Y-=$Resolution.Y/2;//offset cus cam is from -30 to 30
%Vector_2D_Scaled.Y=-%Vector_2D_Scaled.Y;//flip cus -y is down and +y is up
%Vector_2D_Scaled.X=(%Vector_2D_Scaled.X*$Camera_Size.X)/$Resolution.X;
%Vector_2D_Scaled.Y=(%Vector_2D_Scaled.Y*$Camera_Size.Y)/$Resolution.Y;
return %Vector_2D_Scaled;

}

function Scale_Vector_To_Camera(%Vector_2D)
{

%Vector_2D.X=(%Vector_2D.X*$Camera_Size.X)/$Resolution.X;
%Vector_2D.Y=(%Vector_2D.Y*$Camera_Size.Y)/$Resolution.Y;
return %Vector_2D;

}

function Scale_Camera_Vector_To_Resolution(%Vector_2D)
{

%Vector_2D.X=(%Vector_2D.X*$Resolution.X)/$Camera_Size.X;
%Vector_2D.Y=(%Vector_2D.Y*$Resolution.Y)/$Camera_Size.Y;
return %Vector_2D;

}

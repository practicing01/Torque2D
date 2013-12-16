function Water1::movewater(%this,%dir,%schedule)
{
if (!%schedule)
{

if (%dir==0)//up
{
cancel(%this.upmoveschedule);
}
else if (%dir==1)//down
{
cancel(%this.downmoveschedule);
}
else if (%dir==2)//left
{
cancel(%this.leftmoveschedule);
}
else if (%dir==3)//right
{
cancel(%this.rightmoveschedule);
}

return;
}

if (%dir==0)//up
{

for (%x=0;%x<%this.simset_caustictiles.getCount();%x++)
{

%tile=%this.simset_caustictiles.getObject(%x);

%tile.Position.Y++;

%toplimit=ScalePositionVectorToCam(0 SPC -(%this.causticass.getCellHeight()));

if (%tile.Position.Y>%toplimit.Y)
{

%bottomlimit=ScalePositionVectorToCam(0 SPC $resolution.Y+(%this.causticass.getCellHeight()));

%tile.Position.Y=%bottomlimit.Y+(%tile.Position.Y-%toplimit.Y);

}

}

%this.upmoveschedule=schedule(25,0,"Water1::movewater",%this,%dir,1);
}
else if (%dir==1)//down
{

for (%x=0;%x<%this.simset_caustictiles.getCount();%x++)
{

%tile=%this.simset_caustictiles.getObject(%x);

%tile.Position.Y--;

%bottomlimit=ScalePositionVectorToCam(0 SPC $resolution.Y+%this.causticass.getCellHeight());

if (%tile.Position.Y<%bottomlimit.Y)
{

%toplimit=ScalePositionVectorToCam(0 SPC -(%this.causticass.getCellHeight()));

%tile.Position.Y=%toplimit.Y-(%bottomlimit.Y-%tile.Position.Y);

}

}

%this.downmoveschedule=schedule(25,0,"Water1::movewater",%this,%dir,1);
}
else if (%dir==2)//left
{

for (%x=0;%x<%this.simset_caustictiles.getCount();%x++)
{

%tile=%this.simset_caustictiles.getObject(%x);

%tile.Position.X--;

%leftlimit=ScalePositionVectorToCam(-(%this.causticass.getCellWidth()) SPC 0);

if (%tile.Position.X<%leftlimit.X)
{

%rightlimit=ScalePositionVectorToCam($resolution.X+%this.causticass.getCellWidth() SPC 0);

%tile.Position.X=%rightlimit.X-(%leftlimit.X-%tile.Position.X);

}

}

%this.leftmoveschedule=schedule(25,0,"Water1::movewater",%this,%dir,1);
}
else if (%dir==3)//right
{

for (%x=0;%x<%this.simset_caustictiles.getCount();%x++)
{

%tile=%this.simset_caustictiles.getObject(%x);

%tile.Position.X++;

%rightlimit=ScalePositionVectorToCam($resolution.X+(%this.causticass.getCellWidth()) SPC 0);

if (%tile.Position.X>%rightlimit.X)
{

%leftlimit=ScalePositionVectorToCam(-(%this.causticass.getCellWidth()) SPC 0);

%tile.Position.X=%leftlimit.X+(%tile.Position.X-%rightlimit.X);

}

}

%this.rightmoveschedule=schedule(25,0,"Water1::movewater",%this,%dir,1);
}

}

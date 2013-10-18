function ParticleEditorToy::create( %this )
{
    // Reset the toy.    
    ParticleEditorToy.reset();
}

//-----------------------------------------------------------------------------

function ParticleEditorToy::destroy( %this )
{
}

//-----------------------------------------------------------------------------

function ParticleEditorToy::reset( %this )
{
    // Clear the scene.
    SandboxScene.clear();
            
    %effect = new ParticleAsset();
    
    %effect.AssetName = "ForceBubble";
    
//particle asset fields
/*

    LifeMode
        setLifeMode(enum) INFINITE, CYCLE, KILL, and STOP
        getLifeMode()
    Lifetime
        setLifetime(float)
        getLifetime()

*/

//particle asset graphs
/*

    LifetimeScale
    QuantityScale
    SizeXScale
    SizeYScale
    SpeedScale
    SpinScale
    FixedForceScale
    RandomMotionScale
    AlphaChannelScale

*/
    
    %emitter = %effect.createEmitter();
    
    %emitter.EmitterName = "MovingBubbles";
    %emitter.Image = "ToyAssets:Particles5";
    %emitter.Frame = "1";
    
/*
//////////////
//emitter fields
//////////////


    EmitterName
        setEmitterName(string)
        getEmitterName()
    EmitterType
        setEmitterType(enum)  POINT, LINE, BOX, DISK, ELLIPSE, and TORUS
        getEmitterType()
    EmitterOffset
        setEmitterOffset(vector)
        getEmitterOffset()
    EmitterAngle
        setEmitterAngle(float)
        getEmitterAngle()
    EmitterSize
        setEmitterSize(vector)
        getEmitterSize()
    FixedAspect
        setFixedAspect(bool)
        getFixedAspect()
    FixedForceAngle
        setFixedForceAngle(float)
        getFixedForceAngle()
    OrientationType
        setOrientationType(enum)
        getOrientationType()
    KeepAligned
        setKeepAligned(bool)
        getKeepAligned()
    AlignedAngleOffset
        setAlignedAngleOffset(float)
        getAlignedAngleOffset()
    RandomAngleOffset
        setRandomAngleOffset(float)
        getRandomAngleOffset()
    RandomArc
        setRandomArc(float)
        getRandomArc()
    FixedAngleOffset
        setFixedAngleOffset(float)
        getFixedAngleOffset()
    PivotPoint
        setPivotPoint(vector)
        getPivotPoint()
    LinkEmissionRotation
        setLinkEmissionRotation(bool)
        getLinkEmissionRotation()
    IntenseParticles
        setIntenseParticles(bool)
        getIntenseParticles()
    SingleParticle
        setSingleParticle(bool)
        getSingleParticle()
    AttachPositionToEmitter
        setAttachPositionToEmitter(bool)
        getAttachPositionToEmitter()
    AttachRotationToEmitter
        setAttachRotationToEmitter(bool)
        getAttachRotationToEmitter()
    OldestInFront
        setOldestInFront(bool)
        getOldestInFront()
    BlendMode
        setBlendMode(bool)
        getBlendMode()
    SrcBlendFactor
        setSrcBlendFactor(enum)
        getSrcBlendFactor()
    DstBlendFactor
        setDstBlendFactor(enum)
        getDstBlendFactor()
    AlphaTest
        setAlphaTest(float)
        getAlphaTest()
    Image
        setImage(ImageAssetId)
        getImage()
    Frame
        setImageFrame(integer)
        getImageFrame()
    RandomImageFrame
        setRandomImageFrame(bool)
        getRandomImageFrame()
    Animation
        setAnimation(AnimationAssetId)
        getAnimation()


///////////////
//emitter graphs
//////////////
    Lifetime
        LifetimeVariation
    Quantity
        QuantityVariation
    SizeX
        SizeXVariation
        SizeXLife
    SizeY
        SizeYVariation
        SizeYLife
    Speed
        SpeedVariation
        SpeedLife
    Spin
        SpinVariation
        SpinLife
    FixedForce
        FixedForceVariation
        FixedForceLife
    RandomMotion
        RandomMotionVariation
        RandomMotionLife
    EmissionForce
        EmissionForceVariation
    EmissionAngle
        EmissionAngleVariation
    EmissionArc
        EmissionArcVariation
    RedChannel
    GreenChannel
    BlueChannel
    AlphaChannel

*/

%emitter.selectField("Lifetime");
%emitter.addDataKey(0, 5);
%emitter.deselectField();

%emitter.selectField("Quantity");
%emitter.addDataKey(0, 0.2);
%emitter.deselectField();

%emitter.selectField("QuantityVariation");
%emitter.addDataKey(0, 0.1);
%emitter.deselectField();

%emitter.selectField("SizeX");
%emitter.addDataKey(0, 72);
%emitter.deselectField();

%emitter.selectField("SizeXLife");
%emitter.addDataKey(0, 0.3);
%emitter.addDataKey(1, 1);
%emitter.deselectField();

%emitter.selectField("Speed");
%emitter.addDataKey(0, 0);
%emitter.deselectField();

%emitter.selectField("AlphaChannel");
%emitter.addDataKey(0, 0);
%emitter.addDataKey(0.3, 0.2);
%emitter.addDataKey(0.9, 0.1);
%emitter.addDataKey(1, 0);
%emitter.deselectField();

    %assetId = AssetDatabase.addPrivateAsset(%effect);
    
    %player = new ParticlePlayer();
    %player.Particle = %assetId;
    
    // Add the sprite to the scene.
    SandboxScene.add( %player );    
    
    TamlWrite(%effect,"./effect.txt");
    TamlWrite(%emitter,"./emitter.txt");
    TamlWrite(%player,"./player.txt");
}

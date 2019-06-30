
function GameToy::create(%this)
{
	GameToy.mySpriteSize=75;
	new ScriptObject(InputManager);
	InputManager.Init_controls();
	GameToy.reset();
	
}
function GameToy::destroy(%this)
{
	echo("@@@shaveen destroyed toy");
	shipcontrols.pop();
}
function GameToy::reset(%this)
{
	SandboxScene.clear();
	SandboxScene.setGravity(0,0);
	%size=GameToy.mySpriteSize SPC GameToy.mySpriteSize;
	%position="0 0";
	%this.buildBackground(%position,%size);
	%this.buildRoad("1 0",62 SPC 70);
	%this.setCar1("-9 -32",3 SPC 3);
	%this.setCar2("-9 -27",3 SPC 3);
	%this.buildBomb("0 0");	
	%this.buildBomb("15 0");
	%this.buildBomb("29 0");	
	%this.buildBomb("15 30");
	%this.buildFuel("15 26");	
	%this.buildBarriers();
	
	

}

function GameToy::buildBarriers(%this){
	%this.buildBarrel("0 -36");
	%this.buildBarrel("5 -36");
	%this.buildBarrel("10 -36");
	%this.buildBarrel("15 -36");
	%this.buildBarrel("20 -36");
	%this.buildBarrel("25 -34");
	%this.buildBarrel("30 -30");
	%this.buildBarrel("32 -25");
	%this.buildBarrel("33.5 -19");
	%this.buildBarrel("33.5 -13");
	%this.buildBarrel("33.5 -7");
	%this.buildBarrel("33.5 -1");
	%this.buildBarrel("33.5 5");
	%this.buildBarrel("33.5 11");
	%this.buildBarrel("33.5 17");
	%this.buildBarrel("33.5 23");
	%this.buildBarrel("32 29");
	%this.buildBarrel("29 33");
	%this.buildBarrel("25 35");
	%this.buildBarrel("20 35");
	%this.buildBarrel("15 35");
	%this.buildBarrel("10 35");
	%this.buildBarrel("5 35");
	%this.buildBarrel("0 35");
	%this.buildBarrel("-5 35");
	%this.buildBarrel("-10 36");
	%this.buildBarrel("-15 36");
	%this.buildBarrel("-20 35.5");
	%this.buildBarrel("-25 33");
	%this.buildBarrel("-29 29");
	%this.buildBarrel("-31 23");
	%this.buildBarrel("-31.5 17");
	%this.buildBarrel("-31.5 12");
	%this.buildBarrel("-31.5 7");
	%this.buildBarrel("-31.5 2");
	%this.buildBarrel("-31.5 -3");
	%this.buildBarrel("-31.5 -8");
	%this.buildBarrel("-31.5 -13");
	%this.buildBarrel("-31.5 -18");
	%this.buildBarrel("-31.5 -23");
	%this.buildBarrel("-31.5 -28");
	%this.buildBarrel("-31.5 -33");
	%this.buildBarrel("-5 -36");
	%this.buildBarrel("-10 -36");
	%this.buildBarrel("-15 -36");
	%this.buildBarrel("-20 -36");
	%this.buildBarrel("-25 -36");
	%this.buildBarrel("-30 -36");
	
}


function GameToy::buildBackground(%this,%position,%size)
{
	%sprite = new Sprite();
	%sprite.Position=%position;
	%sprite.Size=%size;
	%sprite.Image="GameToy:environment";
	%sprite.setBodyType("static");
	%sprite.setSceneLayer=31;
	SandboxScene.add(%sprite);
	
	
}

function GameToy::buildRoad(%this,%position,%size)
{
	%sprite = new Sprite();
	%sprite.Position=%position;
	%sprite.Size=%size;
	%sprite.Image="GameToy:road";
	%sprite.setBodyType("static");
	%sprite.setSceneLayer=30;
	//%sprite.createPolygonBoxCollisionShape();
	SandboxScene.add(%sprite);
	
	
}
function GameToy::buildBomb(%this,%position)
{	
	%size=3 SPC 3;
	%sprite = new Sprite();
	%sprite.Position=%position;
	%sprite.Size=%size;
	%sprite.Image="GameToy:bomb";
	%sprite.setBodyType("static");
	%sprite.setSceneLayer=29;
	%sprite.SceneGroup=20;
	%sprite.createPolygonBoxCollisionShape();
	SandboxScene.add(%sprite);

   
	
	
}

function GameToy::buildFuel(%this,%position)
{	
	%size=3 SPC 3;
	%sprite = new Sprite();
	%sprite.Position=%position;
	%sprite.Size=%size;
	%sprite.Image="GameToy:fuel";
	%sprite.setBodyType("static");
	%sprite.setSceneLayer=29;
	%sprite.SceneGroup=15;
	%sprite.createPolygonBoxCollisionShape();
	SandboxScene.add(%sprite);

   
	
	
}

function GameToy::buildBarrel(%this,%position)
{	
	%size=3 SPC 3;
	%sprite = new Sprite();
	%sprite.Position=%position;
	%sprite.Size=%size;
	%sprite.Image="GameToy:barrier";
	%sprite.setBodyType("static");
	%sprite.setSceneLayer=29;
	%sprite.SceneGroup=25;
	%sprite.createPolygonBoxCollisionShape();
	SandboxScene.add(%sprite);

   
	
	
}

function GameToy::setCar1(%this,%position,%size)
{
	%sprite = new Sprite(Car1);
	%sprite.Position=%position;
	%sprite.Size=%size;
	%sprite.Image="GameToy:redcar";
	%sprite.setBodyType("dynamic");
	%sprite.setSceneLayer=29;
	%sprite.createPolygonBoxCollisionShape();
	%sprite.setFixedAngle(true);
	%sprite.isThrusting = false;
	%sprite.setCollisionCallback( true );
	SandboxScene.add(%sprite);
	
	
}
function GameToy::setCar2(%this,%position,%size)
{
	%sprite = new Sprite(Car2);
	%sprite.Position=%position;
	%sprite.Size=%size;
	%sprite.Image="GameToy:purplecar";
	%sprite.setBodyType("dynamic");
	%sprite.setSceneLayer=29;
	%sprite.createPolygonBoxCollisionShape();
	%sprite.setFixedAngle(true);
	%sprite.isThrusting = false;
	%sprite.setCollisionCallback( true );
	SandboxScene.add(%sprite);
	
	
}

function InputManager::Init_controls(%this)
{
	//Create our new ActionMap
	new ActionMap(shipcontrols);

	// Press "a" to execute "PlayerShip::turnleft();"
	// Release "a" to execute "PlayerShip::stopturn();"

	shipcontrols.bindCmd(keyboard, "a", "Car1.turnleft();", "Car1.stopturn();");
	shipcontrols.bindCmd(keyboard, "d", "Car1.turnright();", "Car1.stopturn();");
	shipcontrols.bindCmd(keyboard, "w", "Car1.accelerate();", "Car1.stopthrust();");
	shipcontrols.bindCmd(keyboard, "j", "Car2.turnleft();", "Car2.stopturn();");
	shipcontrols.bindCmd(keyboard, "l", "Car2.turnright();", "Car2.stopturn();");
	shipcontrols.bindCmd(keyboard, "i", "Car2.accelerate();", "Car2.stopthrust();");

	//Push our ActionMap on top of the stack
	shipcontrols.push();
}

function Car1::accelerate(%this)  
{  
	echo("@@@shaveen pressed W");
    //Get the angle of our spaceship. When the ship is pointing upwards, its Angle is 90.  
    %adjustedAngle = -(%this.Angle-90) ;  
	echo (%adjustedAngle);
	//echo (%this.Angle);
  
    //When used as a math operand, % refers to modulo (or modulus) operator  
    //This function can be read as %adjusted angle = %adjustedAngle % 360;  
    //%adjustedAngle %= 360;  
  
    //If we are thrusting, shorten our vector  
    if(%this.isThrusting)  
    {    
        //Calculate a direction from an Angle and Magnitude  
        %ThrustVector= Vector2Direction(%adjustedAngle,10);  
    }  
    else  
    {  
        %ThrustVector = Vector2Direction(%adjustedAngle,10);  
  
        //We temporarily remove the Damping of Linear Velocity to allow full power!  
        %this.setLinearDamping(0.0);  
  
        //We temporarily increase the Damping of Angular velocity so that the ship turns slower when at full thrust  
        %this.setAngularDamping(2.0);  
    }  
  
    //Adding our position to the ThrustVector determines the strength of our thrust  
    %MywordX = %this.Position.x + %ThrustVector.x;  
    %MywordY = %this.Position.y + %ThrustVector.y;    
  
    //applyLinearImpulse pushes on our spaceship, using %ThrustVector as the impulse vector.  
    //The second parameter is the point in the ship's collision shape used to apply the thrust  
    %this.applyLinearImpulse(%ThrustVector, "0 0");  
  
    //We are now thrusting, we will set this to false when we release the 'w' key  
    %this.isThrusting = true;  
     
    //We create a schedule to repeat this thrust every 100 milliseconds  
    %this.thrustschedule = %this.schedule(100,accelerate);     
}
function Car1::turnleft(%this)
{
	//adds the value of 20 to our current Angular Velocity
	%this.angle=%this.angle+5;
	//%this.setAngularVelocity(%this.getAngularVelocity()- 20);
	%this.turnschedule = %this.schedule(100,turnleft);
}

function Car1::turnright(%this)
{
	//substracts the value of 20 from our current Angular velocity
	%this.angle=%this.angle-5;
	//%this.setAngularVelocity(%this.getAngularVelocity()+ 20);

	%this.turnschedule = %this.schedule(100,turnright);
}

function Car1::stopturn(%this)
{
	//cancels all scheduled turning
	   cancel(%this.turnschedule);
	//Stop us from spinning
	   %this.setAngularVelocity(0);
}

function Car1::stopthrust(%this)
{ 
	//We add Damping to the Linear Velocity, which slows down the ship when the key is released
	%this.setLinearDamping(0.8);
	//We set Angular Damping to 0 so that we can turn as fast as possible
	%this.setAngularDamping(0.0);

	cancel(%this.thrustschedule);

	//we set isThrusting to false to indicate that we are no longer thrusting.
	//Next time we hit 'w', our accelerate function will use a bigger acceleration boost to get us going faster!
	%this.isThrusting = false;
}

function Car2::accelerate(%this)  
{  
	echo("@@@shaveen pressed W");
    //Get the angle of our spaceship. When the ship is pointing upwards, its Angle is 90.  
    %adjustedAngle = -(%this.Angle-90) ;  
	echo (%adjustedAngle);
	//echo (%this.Angle);
  
    //When used as a math operand, % refers to modulo (or modulus) operator  
    //This function can be read as %adjusted angle = %adjustedAngle % 360;  
    //%adjustedAngle %= 360;  
  
    //If we are thrusting, shorten our vector  
    if(%this.isThrusting)  
    {    
        //Calculate a direction from an Angle and Magnitude  
        %ThrustVector= Vector2Direction(%adjustedAngle,10);  
    }  
    else  
    {  
        %ThrustVector = Vector2Direction(%adjustedAngle,10);  
  
        //We temporarily remove the Damping of Linear Velocity to allow full power!  
        %this.setLinearDamping(0.0);  
  
        //We temporarily increase the Damping of Angular velocity so that the ship turns slower when at full thrust  
        %this.setAngularDamping(2.0);  
    }  
  
    //Adding our position to the ThrustVector determines the strength of our thrust  
    %MywordX = %this.Position.x + %ThrustVector.x;  
    %MywordY = %this.Position.y + %ThrustVector.y;    
  
    //applyLinearImpulse pushes on our spaceship, using %ThrustVector as the impulse vector.  
    //The second parameter is the point in the ship's collision shape used to apply the thrust  
    %this.applyLinearImpulse(%ThrustVector, "0 0");  
  
    //We are now thrusting, we will set this to false when we release the 'w' key  
    %this.isThrusting = true;  
     
    //We create a schedule to repeat this thrust every 100 milliseconds  
    %this.thrustschedule = %this.schedule(100,accelerate);     
}
function Car2::turnleft(%this)
{
	//adds the value of 20 to our current Angular Velocity
	%this.angle=%this.angle+5;
	//%this.setAngularVelocity(%this.getAngularVelocity()- 20);
	%this.turnschedule = %this.schedule(100,turnleft);
}

function Car2::turnright(%this)
{
	//substracts the value of 20 from our current Angular velocity
	%this.angle=%this.angle-5;
	//%this.setAngularVelocity(%this.getAngularVelocity()+ 20);

	%this.turnschedule = %this.schedule(100,turnright);
}

function Car2::stopturn(%this)
{
	//cancels all scheduled turning
	   cancel(%this.turnschedule);
	//Stop us from spinning
	   %this.setAngularVelocity(0);
}

function Car2::stopthrust(%this)
{ 
	//We add Damping to the Linear Velocity, which slows down the ship when the key is released
	%this.setLinearDamping(0.8);
	//We set Angular Damping to 0 so that we can turn as fast as possible
	%this.setAngularDamping(0.0);

	cancel(%this.thrustschedule);

	//we set isThrusting to false to indicate that we are no longer thrusting.
	//Next time we hit 'w', our accelerate function will use a bigger acceleration boost to get us going faster!
	%this.isThrusting = false;
}

function Car1::onCollision(%this, %sceneobject, %collisiondetails)
{
    //If we have collided with an object belonging to Scenegroup 20,
    //execute the code between the { ... }
    //If we collide with something else, do nothing
  if(%sceneobject.getSceneGroup() == 20)
  {
    // ParticlePlayer is also derived from SceneObject, we add it just like we've added all the other
    //objects so far
    %explosion = new ParticlePlayer();

    //We load the particle asset from our ToyAssets module
    %explosion.Particle = "ToyAssets:impactExplosion";

    //We set the Particle Player's position to %Sceneobject's position
    %explosion.setPosition(%sceneobject.getPosition());

    //This Scales the particles to twice their original size
    %explosion.setSizeScale(2);

    //When we add a Particle Effect to the Scene, it automatically plays
    SandboxScene.add(%explosion);

    //We delete the asteroid
    %sceneobject.safedelete();
	%this.safedelete();
	//GameToy.reset();
    
   
     
  }
   if(%sceneobject.getSceneGroup() == 15)
  {
    
    %sceneobject.safedelete();
	
    
    
     
  }
}

function Car2::onCollision(%this, %sceneobject, %collisiondetails)
{
    //If we have collided with an object belonging to Scenegroup 20,
    //execute the code between the { ... }
    //If we collide with something else, do nothing
  if(%sceneobject.getSceneGroup() == 20)
  {
    // ParticlePlayer is also derived from SceneObject, we add it just like we've added all the other
    //objects so far
    %explosion = new ParticlePlayer();

    //We load the particle asset from our ToyAssets module
    %explosion.Particle = "ToyAssets:impactExplosion";

    //We set the Particle Player's position to %Sceneobject's position
    %explosion.setPosition(%sceneobject.getPosition());

    //This Scales the particles to twice their original size
    %explosion.setSizeScale(2);

    //When we add a Particle Effect to the Scene, it automatically plays
    SandboxScene.add(%explosion);

    //We delete the asteroid
    %sceneobject.safedelete();
	%this.safedelete();
	
    
  
     
  }
  if(%sceneobject.getSceneGroup() == 15)
  {
    
    %sceneobject.safedelete();
	
    
    
     
  }
  
}





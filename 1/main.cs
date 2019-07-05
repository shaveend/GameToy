
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
	alxStopAll();
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
	
	alxStopAll();
	alxPlay("GameToy:BackgroundMusic");

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

	%this.buildBarrel("-18 -23");
	%this.buildBarrel("-18 -22");
	%this.buildBarrel("-18 -20");
	%this.buildBarrel("-18 -18");
	%this.buildBarrel("-18 -16");
	%this.buildBarrel("-18 -14");
	%this.buildBarrel("-18 -12");
	%this.buildBarrel("-16 -11");
	%this.buildBarrel("-13 -12");
	%this.buildBarrel("-10 -13");
	%this.buildBarrel("-7 -14");
	%this.buildBarrel("-4 -15");
	%this.buildBarrel("-1 -16");
	%this.buildBarrel("2 -17");
	%this.buildBarrel("4 -19");
	%this.buildBarrel("6 -20");
	%this.buildBarrel("8 -20");
	%this.buildBarrel("10 -21");
	%this.buildBarrel("12 -22");
	%this.buildBarrel("15 -21");
	%this.buildBarrel("19 -19");
	%this.buildBarrel("18 -21");
	%this.buildBarrel("21 -18");
	

	%this.buildBarrel("-15 -23");
	%this.buildBarrel("-12 -23");
	%this.buildBarrel("-9 -23");
	%this.buildBarrel("-6 -23");
	%this.buildBarrel("-3 -23");
	%this.buildBarrel("0 -23");
	%this.buildBarrel("3 -23");
	%this.buildBarrel("6 -23");
	%this.buildBarrel("9 -23");
	%this.buildBarrel("12 -23");
	%this.buildBarrel("15 -23");
	%this.buildBarrel("18 -23");

	%this.buildBarrel("21 -22");
	%this.buildBarrel("22 -19");
	%this.buildBarrel("22 -16");
	%this.buildBarrel("22 -13");
	%this.buildBarrel("22 -10");
	%this.buildBarrel("22 -7");
	%this.buildBarrel("22 -4");
	%this.buildBarrel("22 -1");
	%this.buildBarrel("22  2");
	%this.buildBarrel("22  4");
	%this.buildBarrel("22  6");
	%this.buildBarrel("22  8");
	%this.buildBarrel("22 -1");
	%this.buildBarrel("22  2");
	%this.buildBarrel("22  4");
	%this.buildBarrel("22  6");
	%this.buildBarrel("22  8");
	%this.buildBarrel("22  10");
	%this.buildBarrel("22  12");
	%this.buildBarrel("22  14");
	%this.buildBarrel("22  16");
	%this.buildBarrel("22  18");

	%this.buildBarrel("22  20");
	%this.buildBarrel("22  22");

	%this.buildBarrel("19  22");
	%this.buildBarrel("16  22");
	%this.buildBarrel("16  21");
	%this.buildBarrel("19  20");
	%this.buildBarrel("20  19");
	
	%this.buildBarrel("13  21");
	%this.buildBarrel("10  21");
	%this.buildBarrel("7  21");
	%this.buildBarrel("4  20");
	%this.buildBarrel("1  21");
	%this.buildBarrel("-2  21");
	%this.buildBarrel("-5  22");
	%this.buildBarrel("-8  23");
	%this.buildBarrel("-11  23");
	%this.buildBarrel("-14  23");
	%this.buildBarrel("-17  23");

	%this.buildBarrel("-18  22");
	%this.buildBarrel("-19  20");
	%this.buildBarrel("-19  17");
	%this.buildBarrel("-18  14");

	%this.buildBarrel("-15  15");
	%this.buildBarrel("-13  17");
	%this.buildBarrel("-12  18");
	%this.buildBarrel("-11  19");
	%this.buildBarrel("-9  20");
	%this.buildBarrel("-6  20");
	%this.buildBarrel("-3  19");
	%this.buildBarrel("-1  17");
	%this.buildBarrel("0  15");
	%this.buildBarrel("1  14");
	%this.buildBarrel("2  13");
	%this.buildBarrel("1  12");
	%this.buildBarrel("2  11");
	%this.buildBarrel("2  10");
	%this.buildBarrel("2  9");
	%this.buildBarrel("3  8");
	%this.buildBarrel("3  9");
	%this.buildBarrel("3  10");
	%this.buildBarrel("4  11");
	%this.buildBarrel("4  12");
	%this.buildBarrel("5  14");
	%this.buildBarrel("7  16");
	%this.buildBarrel("8  18");
	%this.buildBarrel("9  19");
	%this.buildBarrel("10  20");

	%this.buildBarrel("0  -4");
	%this.buildBarrel("3  -5");
	%this.buildBarrel("6  -6");
	%this.buildBarrel("9  -7");
	%this.buildBarrel("11  -8");
	%this.buildBarrel("11  -6");
	%this.buildBarrel("11  -4");
	%this.buildBarrel("11  -2");
	%this.buildBarrel("11  0");
	%this.buildBarrel("9  -2");

	%this.buildBarrel("-5  -2");
	%this.buildBarrel("-8  0");
	%this.buildBarrel("-11  1");
	%this.buildBarrel("-8  4");
	%this.buildBarrel("-7  1");
	%this.buildBarrel("-11  2");
	%this.buildBarrel("-14  2");
	%this.buildBarrel("-17  2");
	%this.buildBarrel("-20  2");		
	%this.buildBarrel("-23  3");
	%this.buildBarrel("-26  5");
	%this.buildBarrel("-28  7");
	%this.buildBarrel("-30  9");

	%this.buildBarrel("-23  0");
	%this.buildBarrel("-25  -1");
	%this.buildBarrel("-27  -3");
	%this.buildBarrel("-29  -5");

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
	shipcontrols.bindCmd(keyboard, "s", "Car1.deaccelerate();", "Car1.stopthrust();");
	shipcontrols.bindCmd(keyboard, "Left", "Car2.turnleft();", "Car2.stopturn();");
	shipcontrols.bindCmd(keyboard, "Right", "Car2.turnright();", "Car2.stopturn();");
	shipcontrols.bindCmd(keyboard, "Up", "Car2.accelerate();", "Car2.stopthrust();");
	shipcontrols.bindCmd(keyboard, "Down", "Car2.deaccelerate();", "Car2.stopthrust();");

	//Push our ActionMap on top of the stack
	shipcontrols.push();
}

function Car1::accelerate(%this)  
{  
	alxPlay("GameToy:carSpeedMusic");
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
function Car1::deaccelerate(%this)  
{  
	%this.setLinearDamping(1.5);
	echo("@@@shaveen pressed S");
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
        %this.setLinearDamping(0.8);
		//Calculate a direction from an Angle and Magnitude  
        %ThrustVector= Vector2Direction(%adjustedAngle,-10);  
    }  
    else  
    {  
        %ThrustVector = Vector2Direction(%adjustedAngle,-10);  
  
        //We temporarily remove the Damping of Linear Velocity to allow full power!  
        %this.setLinearDamping(0.0);  
  
        //We temporarily increase the Damping of Angular velocity so that the ship turns slower when at full thrust  
        %this.setAngularDamping(-2.0);  
    }  
  
    //Adding our position to the ThrustVector determines the strength of our thrust  
    %MywordX = %this.Position.x - %ThrustVector.x;  
    %MywordY = %this.Position.y - %ThrustVector.y;    
  
    //applyLinearImpulse pushes on our spaceship, using %ThrustVector as the impulse vector.  
    //The second parameter is the point in the ship's collision shape used to apply the thrust  
    %this.applyLinearImpulse(%ThrustVector, "0 0");  
  
    //We are now thrusting, we will set this to false when we release the 'w' key  
    %this.isThrusting = true;  
     
    //We create a schedule to repeat this thrust every 100 milliseconds  
    %this.thrustschedule = %this.schedule(150,deaccelerate);     
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
function Car2::deaccelerate(%this)  
{  
	%this.setLinearDamping(1.5);
	echo("@@@shaveen pressed Down");
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
		%this.setLinearDamping(0.8); 
        //Calculate a direction from an Angle and Magnitude  
        %ThrustVector= Vector2Direction(%adjustedAngle,-10);  
    }  
    else  
    {  
        %ThrustVector = Vector2Direction(%adjustedAngle,-10);  
  
        //We temporarily remove the Damping of Linear Velocity to allow full power!  
        %this.setLinearDamping(0.0);  
  
        //We temporarily increase the Damping of Angular velocity so that the ship turns slower when at full thrust  
        %this.setAngularDamping(2.0);  
    }  
  
    //Adding our position to the ThrustVector determines the strength of our thrust  
    %MywordX = %this.Position.x - %ThrustVector.x;  
    %MywordY = %this.Position.y - %ThrustVector.y;    
  
    //applyLinearImpulse pushes on our spaceship, using %ThrustVector as the impulse vector.  
    //The second parameter is the point in the ship's collision shape used to apply the thrust  
    %this.applyLinearImpulse(%ThrustVector, "0 0");  
  
    //We are now thrusting, we will set this to false when we release the 'w' key  
    %this.isThrusting = true;  
     
    //We create a schedule to repeat this thrust every 100 milliseconds  
    %this.thrustschedule = %this.schedule(150,deaccelerate);     
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





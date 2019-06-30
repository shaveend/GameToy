
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
	%this.setCar1("-9 -32",4 SPC 4);
	%this.setCar2("-9 -27",4 SPC 4);
	
	

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





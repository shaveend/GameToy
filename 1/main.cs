
function GameToy::create(%this)
{
	exec("./scripts/shaveenScript.cs");
	GameToy.mySpriteSize=75;
	//addNumericOption("Sprite size", 1, 15, 1, "setMySpriteSize", %this.mySpriteSize, true, "Determines Sprite Size");
	//setMySpriteSize(GameToy.mySpriteSize);
	GameToy.reset();
	
}
function GameToy::destroy(%this)
{
	echo("@@@shaveen destroyed toy");
}
function GameToy::reset(%this)
{
	SandboxScene.clear();
	SandboxScene.setGravity(0,0);
	%size=GameToy.mySpriteSize SPC GameToy.mySpriteSize;
	%position="0 0";
	%sprite=buildShaveenSprite(%position,%size);
	
	SandboxScene.add(%sprite);

}

function GameToy::setMySpriteSize(%this, %value)
{
	GameToy.mySpriteSize=%value;
}
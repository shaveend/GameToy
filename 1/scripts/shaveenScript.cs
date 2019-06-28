function buildShaveenSprite(%position,%size)
{
	%sprite = new Sprite();
	%sprite.Position=%position;
	%sprite.Size=%size;
	%sprite.Image="GameToy:environment";
	%sprite.setBodyType("static");
	return %sprite;
}
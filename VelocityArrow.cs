using Godot;
using System;

public partial class VelocityArrow : Node3D
{
    [Export]
    public Player player;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		LookAt(player.Position + player.velocity);
	}
}

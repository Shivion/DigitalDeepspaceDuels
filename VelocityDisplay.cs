using Godot;
using System;

public partial class VelocityDisplay : Label
{
    [Export]
    public Player player;

    public override void _Process(double delta)
    {
        Text = "Velocity: " + player.velocity.Length().ToString();
    }
}

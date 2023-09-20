using Godot;
using System;

public partial class TargetArrow : Node3D
{
    [Export]
    public Target target;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
    {
        LookAt(target.Position);
    }
}

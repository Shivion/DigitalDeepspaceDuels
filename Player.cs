using Godot;
using System;

public partial class Player : CharacterBody3D
{
	[Export]
	public float acceleration;
    [Export]
    public float turnSpeed;

	public Vector3 velocity;

	private const float c = 299792458;

	public override void _PhysicsProcess(double delta)
	{
		if (Input.IsActionPressed("forward"))
		{
            velocity += Basis.Z.Normalized() * acceleration;
        }
		if (Input.IsActionPressed("turn_left"))
		{
            RotationDegrees += new Vector3(0, 1, 0) * turnSpeed;
		}
		if (Input.IsActionPressed("back"))
		{
			velocity -= Basis.Z.Normalized() * acceleration / 2;
		}
		if (Input.IsActionPressed("turn_right"))
		{
            RotationDegrees -= new Vector3(0, 1, 0) * turnSpeed;
		}

		Position += velocity;
	}

	//This might as well say return 1 without some changes. But I'll forget it if I move it
	private float Gamma()
	{
		return 1 / Mathf.Sqrt(1 - (velocity.Length() / c) * (velocity.Length() / c));
	}
	
}

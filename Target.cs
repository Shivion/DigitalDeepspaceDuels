using Godot;
using System;
using System.Collections.Generic;

public partial class Target : RigidBody3D
{
	static List<Target> targets = new List<Target>();

	const float spawningRange = 100;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        targets.Add(this);
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

    internal static void ResetTarget(Godot.Collections.Dictionary raycastResult)
    {
		foreach (Target target in targets) 
		{
			if (raycastResult["collider"].AsGodotObject() == target)
			{
                target.ResetTarget();
			}
		}
    }

    private void ResetTarget()
    {
		Score.AddPoint();
        RandomNumberGenerator rngseed = new RandomNumberGenerator();
        Position += new Vector3(rngseed.RandfRange(-spawningRange, spawningRange), 0, rngseed.RandfRange(-spawningRange, spawningRange));
    }
}

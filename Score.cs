using Godot;
using System;

public partial class Score : Label
{
    static int score = 0;

    internal static void AddPoint()
    {
        score++;
    }

    public override void _Process(double delta)
    {
        Text = "Score: " + score.ToString();
    }
}

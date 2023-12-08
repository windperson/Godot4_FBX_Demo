using Godot;
using System;

public partial class RotateNode : CsgBox3D
{
    private float _angleSpeed = 30.0f;
    
    [Export]
    public float AngularSpeed
    {
        get => _angleSpeed;
        set => _angleSpeed = value;
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("RotateNode.cs: _Ready()");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        var yRotateIncrement = (float)delta * _angleSpeed;
        GD.Print($"yRotateIncrement: {yRotateIncrement}");
        RotationDegrees = RotationDegrees with{ Y = RotationDegrees.Y + yRotateIncrement };
    }
}
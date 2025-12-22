using Godot;

public partial class Player : CharacterBody2D
{
    // called once per frame - typically movement code
    // -> use instead of _PhysicsProcess since _PP runs default 60hz rate,
    //    so it's more choppy on high refresh rate monitors
    public override void _Process(double delta)
    {

        Vector2 movementVector = Input.GetVector(
            "move_left", "move_right", "move_up", "move_down"
            );

        // CharacterBody2D attribute
        Velocity = movementVector * 100; // pixels per second
        MoveAndSlide(); // accounts for Process or PhysicsProcess
    }
}

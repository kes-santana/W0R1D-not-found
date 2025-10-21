using Godot;

public abstract partial class Entity : CharacterBody2D
{
    protected EntityData _entityData;
    protected TurnContext _turnContext;
    protected Decisions decision;
    protected dynamic @params;

    protected Entity(EntityData entityData)
    {
        _entityData = entityData;
    }

    private Vector2 velocity = Vector2.Zero;
    private float speed = 200f;

    public abstract void UpdateAction();

    public override void _PhysicsProcess(double delta)
    {
        UpdateAction();

        switch (decision)
        {
            case Decisions.Move:
                Move(@params);
                break;
        }

        UpdateContext();
    }

    public void UpdateContext()
    {
        _turnContext.CollisionDetected = GetSlideCollisionCount() > 0;
    }

    public virtual void Move(dynamic data)
    {
        Directions dir = data.dir;

        Vector2 directionVector = DirectionToVector(dir);
        Velocity = new Vector2(directionVector.X * speed, Velocity.Y);

        _turnContext.LastDir = dir;

        MoveAndSlide();
    }

    private Vector2 DirectionToVector(Directions dir)
    {
        return dir switch
        {
            Directions.Left => Vector2.Left,
            Directions.Right => Vector2.Right,
            _ => Vector2.Zero,
        };
    }
}

public class MoveHorizontal : IStrategy
{
    public (Decisions, dynamic) GetAction(dynamic IAContext)
    {
        if (!IAContext.EnviromentContext.CollisionDetected)
        {
            return (Decisions.Move, IAContext.LastDir);
        }

        return IAContext.LastDir switch
        {
            Directions.Left => (Decisions.Move, Directions.Right),
            _ => (Decisions.Move, Directions.Left),
        };
    }
}

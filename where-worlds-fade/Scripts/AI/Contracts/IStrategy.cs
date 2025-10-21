public interface IStrategy
{
    (Decisions, dynamic) GetAction(dynamic IAContext);
}

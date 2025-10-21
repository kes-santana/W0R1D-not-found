using System.Collections.Generic;

public abstract class FSM
{
    protected State state;
    protected Dictionary<State, IStrategy> strategies;

    public abstract void UpdateState(EntityData entityData, TurnContext enviromentContext);
    public abstract (Decisions, dynamic) AnalyzeState(
        EntityData entityData,
        TurnContext enviromentContext
    );
}

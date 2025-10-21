public class FSMSideWalker : FSM
{
    public override (Decisions, dynamic) AnalyzeState(
        EntityData entityData,
        TurnContext turnContext
    )
    {
        return strategies[state]
            .GetAction(new { EntityData = entityData, TurnContext = turnContext });
    }

    public override void UpdateState(EntityData entityData, TurnContext turnContext) { }
}

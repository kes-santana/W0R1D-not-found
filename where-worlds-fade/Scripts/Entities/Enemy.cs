public partial class Enemy : Entity
{
    private FSM _stateMachine;

    public Enemy(FSM stateMachine, EntityData entityData)
        : base(entityData)
    {
        _stateMachine = stateMachine;
    }

    public override void UpdateAction()
    {
        _stateMachine.UpdateState(_entityData, _turnContext);
        var data = _stateMachine.AnalyzeState(_entityData, _turnContext);
        (decision, @params) = (data.Item1, data.Item2);
    }
}

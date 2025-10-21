using System;

public static class StateMachineFactory
{
    public static FSM CreateStateMachine(EnemyTypes type)
    {
        return type switch
        {
            EnemyTypes.SideWalker => new FSMSideWalker(),
            _ => throw new InvalidOperationException(),
        };
    }
}

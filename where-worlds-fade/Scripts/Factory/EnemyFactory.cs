using System;

public static class EnemyFactory
{
    public static Enemy CreateEnemy(EnemyTypes type)
    {
        FSM stateMachine = StateMachineFactory.CreateStateMachine(type);
        return new Enemy(stateMachine, new EntityData());
    }
}

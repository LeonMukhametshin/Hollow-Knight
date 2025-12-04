using System;
using System.Collections.Generic;

public class FSM
{
    public FsmState CurrentState { get; private set; }

    private Dictionary<Type, FsmState> m_states = new();

    public void AddState(FsmState state)
    {
        m_states.Add(state.GetType(), state);
    }

    public void SetState<T>() where T : FsmState
    {
        var type = typeof(T);

        if (CurrentState != null && CurrentState.GetType() == type)
        {
            return;
        }

        if(m_states.TryGetValue(type, out var newState))
        {
            CurrentState?.Exit();
            CurrentState = newState;
            CurrentState?.Enter();
        }
    }

    public void Update()
    {
        CurrentState?.Update();
    }

    public void FixedUpdate()
    {
        CurrentState?.FixedUpdate();
    }
}
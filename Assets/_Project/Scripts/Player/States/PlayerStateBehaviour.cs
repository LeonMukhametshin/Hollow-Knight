using UnityEngine;

public class PlayerStateBehaviour : MonoBehaviour
{
    private FSM m_fsm;
    private float m_walkSpeed = 10f;
    private float m_runSpeed = 20f;

    private void Start()
    {
        m_fsm = new FSM();
        m_fsm.AddState(new PlayerStateIdle(m_fsm));
        m_fsm.AddState(new PlayerStateWalk(m_fsm, this.transform, m_walkSpeed));
        m_fsm.AddState(new PlayerStateRun(m_fsm, this.transform, m_runSpeed));

        m_fsm.SetState<PlayerStateIdle>();
    }

    private void Update()
    {
        m_fsm.Update();
    }
}
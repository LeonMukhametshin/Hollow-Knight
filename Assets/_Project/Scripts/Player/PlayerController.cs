using PlayerStateMachine;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private FSM m_fsm;
    private IInputService m_inputService;
    private PlayerContext m_playerContext;

    [SerializeField] private PlayerData m_playerData;
    [SerializeField] private Rigidbody2D m_rigidbody;

    private void Awake()
    {
        m_fsm = new FSM();

        m_inputService = new InputService();
        m_playerContext = new PlayerContext(m_inputService, m_rigidbody, m_playerData);

        m_fsm.AddState(new PlayerStateIdle(m_fsm, m_playerContext));
        m_fsm.AddState(new PlayerStateWalk(m_fsm, m_playerContext, new VelocityMovement()));
        m_fsm.AddState(new PlayerStateRun(m_fsm, m_playerContext, new VelocityMovement()));
        m_fsm.AddState(new PlayerStateJump(m_fsm, m_playerContext, new JumpVarian()));

        m_fsm.SetState<PlayerStateIdle>();
    }

    private void Update()
    {
        m_inputService.Update();
        m_fsm?.Update();
    }

    private void FixedUpdate()
    {
        m_fsm?.FixedUpdate();
    }
}
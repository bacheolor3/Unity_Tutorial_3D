using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class StudyState : MonoBehaviour
{
    public IState state = new IdleState();

    private IState idleState, moveState, attackState, jumpState;

    private void Awake()
    {
        idleState = gameObject.AddComponent<IdleState>();
        moveState = gameObject.AddComponent<MoveState>();
        attackState = gameObject.AddComponent<AttackState>();
        jumpState = gameObject.AddComponent<JumpState>();

        state = idleState;
    }

    private void Start()
    {
        state.StateEnter();
    }

    private void OnDestroy()
    {
        state.StateExit();
    }

    private void Update()
    {        
        state?.StateUpdate();

        #region function test


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetState(idleState);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetState(moveState);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetState(attackState);
        }
        #endregion
    }

    public void SetState(IState newState)
    {
        if(state != newState)
        {
            state.StateExit();

            state = newState;

            state.StateEnter();
        }
    }
    
}

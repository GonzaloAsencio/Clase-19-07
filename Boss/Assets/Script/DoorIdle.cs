using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorIdle : StateMachineBehaviour
{
    [SerializeField] private float Cd;
    private float AttackCD;
    [SerializeField] private int Attack;
 

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AttackCD = Cd;
        Attack = Random.Range(0, 2);
        animator.SetInteger("RandomAttack", Attack);
      
        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Cd -= Time.deltaTime;
        if (Cd <= 0)
        {
           
           
            animator.SetTrigger("Attack");
        }
    }


    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Cd = AttackCD;
        animator.ResetTrigger("Attack");
    }


}

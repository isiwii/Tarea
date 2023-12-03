using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolsies : StateMachineBehaviour
{

    private PatrolSpots patrol;
    public float speed;
    private int randomSpot;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       patrol = GameObject.FindGameObjectWithTag("PatrolSpots").GetComponent<PatrolSpots>();
       randomSpot = Random.Range(0, patrol.patrolPoints.Length);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if(Vector3.Distance(animator.transform.position, patrol.patrolPoints[randomSpot].position) > 0.2f)
       {
        animator.transform.position = Vector3.MoveTowards(animator.transform.position, patrol.patrolPoints[randomSpot].position, speed * Time.deltaTime);
       }
       else
       {
            randomSpot = Random.Range(0, patrol.patrolPoints.Length);
       }

       if(Input.GetKeyDown(KeyCode.Space)) {
            animator.SetBool("isFollowing", false);
       }
}
       

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyFSM : StateMachineBehaviour
{
    public float chaseDistance = 1f; // Adjust this distance as needed
    private Transform Player;
    private Transform enemyTransform;
    public static bool isFollowing = false;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyTransform = animator.transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float distanceToPlayer = Vector3.Distance(enemyTransform.position, Player.position);

        if (distanceToPlayer <= chaseDistance)
        {
            isFollowing = true;
        }
        else
        {
            isFollowing = false;
        }

        // Change states based on distance
        animator.SetBool("isFollowing", isFollowing);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Reset any necessary parameters or actions when exiting the state
        animator.SetBool("isFollowing", false);
    }
}
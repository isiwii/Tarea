using UnityEngine;

public class Rotating : StateMachineBehaviour
{
    private Transform playerPos;
    public float speed;
    public float followDistance = 2f; // Adjust this distance as needed

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float distanceToPlayer = Vector3.Distance(animator.transform.position, playerPos.position);

        if (distanceToPlayer <= followDistance)
        {
            animator.SetBool("isFollowing", true);
        }
        else
        {
            animator.SetBool("isFollowing", false);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
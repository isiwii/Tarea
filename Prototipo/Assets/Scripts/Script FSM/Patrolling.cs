using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    public Transform[] patrolPoints;
    private int currentPatrolIndex = 0;
    public float moveSpeed = 1f;

    void Update()
    {
        // Move towards the current patrol point
       

        if (!EnemyFSM.isFollowing)
        {
             transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPatrolIndex].position, moveSpeed * Time.deltaTime);

        // Check if reached the patrol point, then move to the next one
        if (Vector3.Distance(transform.position, patrolPoints[currentPatrolIndex].position) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }
        }
    }
}
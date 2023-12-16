using UnityEngine;
using UnityEngine.PlayerLoop;

public class Wind : MonoBehaviour
{
    public Vector3 destination;
    public Vector3 initialPosition;
    
    public float moveSpeed = 5.0f;
    public float destroyDelay = 6.0f;

    private float elapsedTime = 0.0f;

    /*void Start()
    {
        initialPosition = transform.position; // Save the initial position as a respawn point
    }*/

    void Update()
    {
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, destination, step);

        // Measure time elapsed
        elapsedTime += Time.deltaTime;

        // If the object reaches the destination or the elapsed time exceeds the delay
        if (transform.position == destination || elapsedTime >= destroyDelay)
        {
            Destroy(gameObject);
            //transform.position = initialPosition;
        }
    }
}
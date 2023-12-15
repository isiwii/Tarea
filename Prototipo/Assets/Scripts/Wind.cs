using UnityEngine;

public class Wind : MonoBehaviour
{
    public Vector3 destination;
    public float moveSpeed = 5.0f;
    public float destroyDelay = 3.0f;

    private float elapsedTime = 0.0f;

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
        }
    }
}
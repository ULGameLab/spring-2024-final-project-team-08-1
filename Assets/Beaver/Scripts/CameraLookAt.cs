using UnityEngine;

public class AlligatorRoam : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float rotateSpeed = 50.0f;
    private float nextActionTime = 0.0f;
    public float period = 2f; // Seconds to wait before deciding new movement.

    void Update()
    {
        // If it's time to decide on the next action, either move forward or rotate.
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            DecideNextAction();
        }
    }

    void DecideNextAction()
    {
        // Randomly choose to move forward or rotate
        if (Random.Range(0, 2) == 0)
        {
            MoveForward();
        }
        else
        {
            Rotate();
        }
    }

    void MoveForward()
    {
        // Move forward in the current facing direction
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void Rotate()
    {
        // Rotate a random amount up to 180 degrees, either left or right
        transform.Rotate(Vector3.up, Random.Range(-180, 180) * rotateSpeed * Time.deltaTime);
    }
}

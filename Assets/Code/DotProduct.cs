using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float speed = 5f;

    private Vector3 direction;

    void Start()
    {
        direction = Vector3.right.normalized;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        WallCollision();
    }

    void WallCollision()
    {
        Vector3 localPosition = transform.localPosition;

        // Wall (1)
        if (Vector3.Dot(direction, Vector3.right) > 0 && localPosition.x >= 7f)
        {
            direction = Vector3.left.normalized;
        }

        // Wall (2)
        else if (Vector3.Dot(direction, Vector3.left) > 0 && localPosition.x <= -7f)
        {
            direction = Vector3.right.normalized;
        }
    }
}

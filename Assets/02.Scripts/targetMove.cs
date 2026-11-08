using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class targetMove : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(moveSpeed, 0, 0);

        if (transform.position.x > 18)
        {
            moveSpeed = -1;
        }

        if (transform.position.x < -18)
        {
            moveSpeed = 1;
        }
    }
}
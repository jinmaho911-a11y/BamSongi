using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class targetMove : MonoBehaviour
{
    int i = 1;

    void Update()
    {
        transform.Translate(0.01f * i, 0, 0);

        if (transform.position.x > 18)
        {
            i = -1;
        }

        if (transform.position.x < -18)
        {
            i = 1;
        }
    }
}
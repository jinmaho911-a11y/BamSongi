using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class targetMove : MonoBehaviour
{
    public float moveSpeed;
    public int score; //타겟 오브젝트가 몇점 짜리 오브젝트이지 알려주게 하기 위해서
    public int GetScore() //이 함수 실행하면 이 타겟의 지정된 점수를 반환해서 얻게 됨.
    {
        return score;
    }

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
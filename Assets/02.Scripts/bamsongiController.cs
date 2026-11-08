using UnityEngine;
using UnityEngine.SceneManagement;

public class bamsongiController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            //Shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    public void Shoot(Vector3 dir)
    {

        GetComponent<Rigidbody>().AddForce(dir);


    }
    private void OnCollisionEnter(Collision collision)
    {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<ParticleSystem>().Play();
    }
}

//파티클 시스템의 대하여
//대충 1번째 칸에서 Looping이란게 있는데 이거 켜져 있으면 무한반복으로 임지ㅣ 나옴
//size of liftime 저거는 파티클이 남아있는 시간이고
//뭐 기타 등등 정확한건 Emission이란건 적당히 얼마나 짧은 간격으로 파티클 나오게 할거냐
//Shape는 얼마나 멀리 가게 할거냐 이거임 왼쪽 V 표시 해야 이거 가동된다.

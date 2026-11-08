using System.Xml;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class bamsongiController : MonoBehaviour
{
    public Text distance_text;
    // 1. 자식으로 설정할 오브젝트
    public Transform bamsongi;

    // 2. 부모가 될 오브젝트
    public Transform target;
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
            transform.SetParent(collision.transform, true);
    }
    void Update()
    {
        float length = bamsongi;

        if (length >= 0)
        {
            distance_text.text = "현재 점수 :" + 20;
        }
        else
        {
            distance_text.text = "게임 오버 예~";
        }


    }

}

//파티클 시스템의 대하여
//대충 1번째 칸에서 Looping이란게 있는데 이거 켜져 있으면 무한반복으로 임지ㅣ 나옴
//size of liftime 저거는 파티클이 남아있는 시간이고
//뭐 기타 등등 정확한건 Emission이란건 적당히 얼마나 짧은 간격으로 파티클 나오게 할거냐
//Shape는 얼마나 멀리 가게 할거냐 이거임 왼쪽 V 표시 해야 이거 가동된다.
// 지금 발견된 버그는 밤송이이가 과녘에 닿으며 ㄴ 그냥 모든 물리법칙 무시하고 공중에 떠있다
//충돌 했을 때 밤송이를 target 오브젝트의 자식 옵젝트로 만들면 자동으로 따라서 움직이게 될 것 같다.
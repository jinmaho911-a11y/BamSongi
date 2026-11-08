using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefb);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bamsongi.GetComponent<bamsongiController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
//그림에 나타나듯이 월드 좌표계와 스크린 좌표계는 전혀 다른 척도(단위)를 사용합니다
//월드 좌표계에서 고양이가 있는 좌표 2, 1, 2와 스크린 좌표계에서 고양이가 있는 좌표 400, 150는 전혀 관계 없는 별개의 좌표임
//지금까지 나온 과녁이나 밤송이 좌표는 모두 월드 좌표계이므로 밤송이를 날리는 방향도 월드 좌표계로 계산해야됨
//    유니티에는 SCreenPintToRay 메서드가 준비 되어있음
//    이 메서드는 스크린 좌표를 전달시 카메라에서 스크린 좌표로 향하는 월드 좌표계로 벡터(다음 그림의 분홍색 백터)를 구할수 있음 이 벡터를 사용해 밤송이를 탭한 방향으로 ㄱㄱ
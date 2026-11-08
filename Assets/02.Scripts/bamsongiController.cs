using UnityEngine;
using UnityEngine.SceneManagement;

public class bamsongiController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            Shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    public void Shoot(Vector3 dir)
    {

        GetComponent<Rigidbody>().AddForce(dir);

    }
    void OnTriggerEnter(Collider other)
    {
            Debug.Log("맞았다! 제 3부 완!");
    }
}


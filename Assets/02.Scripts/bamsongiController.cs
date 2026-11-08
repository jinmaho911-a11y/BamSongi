using UnityEngine;

public class bamsongiController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            Shoot(new Vector3(0, 0, 3000));
    }

    // Update is called once per frame
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
}

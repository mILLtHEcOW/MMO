using UnityEngine;
using System.Collections;

public class CSCamera : MonoBehaviour
{
    public float moveSpeed = 5;
    float x;
    float z;

    Transform csCamrea;
    void Start()
    {
        csCamrea = this.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Debug.Log(x + " " + z);
        z = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
        Vector3 csMove = new Vector3(x, 0, z);
        csCamrea.Translate(csMove * Time.deltaTime * moveSpeed);
    }
}

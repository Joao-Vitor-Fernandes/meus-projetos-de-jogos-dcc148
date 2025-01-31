using UnityEngine;

public class cubeController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion q = Quaternion.AngleAxis(1, Vector3.forward);
        transform.localRotation *= q;

        Vector3 dir = new Vector3(2, 1, 3);
        dir = q * dir;  
    }
}

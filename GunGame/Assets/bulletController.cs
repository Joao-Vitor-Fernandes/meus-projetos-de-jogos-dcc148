using UnityEngine;

public class bulletController : MonoBehaviour
{
    public float speed = 3.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if(transform.position.x < -10) {
            gameObject.SetActive(false);
        }
    }
}

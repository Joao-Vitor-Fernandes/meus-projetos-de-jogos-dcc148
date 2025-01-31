using UnityEngine;

public class enemy1Controller : MonoBehaviour
{
    public float speed = 3.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dx = speed * Time.deltaTime;
        transform.Translate(0, dx, 0);

        if(transform.position.x < -10) {
            gameObject.SetActive(false);
        }
    }

}

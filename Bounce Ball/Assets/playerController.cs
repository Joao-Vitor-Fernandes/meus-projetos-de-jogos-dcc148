using UnityEngine;

public class BounceController : MonoBehaviour
{
    private float velocidade = 10;
    private float gravidade = 10;
    private float impulso = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        

        float dx = Input.GetAxis("Horizontal");
        x += dx * velocidade * Time.deltaTime;

        float dy = gravidade * Time.deltaTime;
        y -= dy;

        if(y < -4)
        {
            y = -4;
            y += impulso;
        }
        
        transform.position = new Vector2(x, y);
    }
}
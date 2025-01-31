using UnityEngine;

public class enemyController : MonoBehaviour
{
    private float velocidade = 10;
    private float direcao = 1;

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
        x += dx * velocidade * direcao * Time.deltaTime;

        if(x > 4){
            direcao = -1;
        } else if (x < -4){
            direcao = 1;
        }



        transform.position = new Vector2(x, y);
    }
}

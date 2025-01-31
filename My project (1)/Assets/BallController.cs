using UnityEngine;

public class BallController : MonoBehaviour
{
    private float speed;

    private Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = new Vector2(-0.5f, 0.5f);
        direction.Normalize();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dv = direction * speed * Time.fixedDeltaTime;
        transform.Translate(dv);
        if(transform.position.y >= 5)
            direction = Vector2.Reflect(direction, Vector2.down);
        else if(transform.position.y <= -5)
            direction = Vector2.Reflect(direction, Vector2.up);
    }

    void OnCollisionEnter2D(Collision2D ball){
        ContactPoint2D contact = ball.GetContact(0);
        direction = Vector2.Reflect(direction, contact.normal);
    }
}

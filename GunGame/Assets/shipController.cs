using UnityEngine;

public class shipController : MonoBehaviour
{
    public float xSpeed = 3.5f;
    public float ySpeed = 3.5f;
    public GameObject shootPrefab;
    public objectPool objectPool;

    // Start is called before the first frame update
    void Start()
    {
        objectPool = new objectPool(shootPrefab, 15);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float vx = Input.GetAxis("Horizontal") * xSpeed;
        float vy = Input.GetAxis("Vertical") * ySpeed;
    
        Vector2 v = new Vector2(vx, vy);
        pos += v * Time.fixedDeltaTime;

        if(pos.y < -5)
        {
            pos.y = -5;
        } else if(pos.y > 5) {
            pos.y = 5;
        }

        if(pos.x < -8)
        {
            pos.x = -8;
        } else if(pos.x > 8) {
            pos.x = 8;
        }

        transform.position = pos;

        if(Input.GetKeyDown(KeyCode.Space)) {
            shoot();
        }
    }

    private void shoot()
    {
        GameObject bullet = objectPool.GetFromPool();

        if (bullet != null)
        {
            bullet.transform.position = transform.position + new Vector3(1, 0);
            bullet.GetComponent<Rigidbody2D>().linearVelocity = Vector2.right * 10f;

            StartCoroutine(DestroyBulletAfterTime(bullet, 2f));
        }
    }

    private System.Collections.IEnumerator DestroyBulletAfterTime(GameObject bullet, float time)
    {
        yield return new WaitForSeconds(time);

        objectPool.ReturnToPool(bullet);
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag == "Enemy")
            Destroy(gameObject);
    }
}

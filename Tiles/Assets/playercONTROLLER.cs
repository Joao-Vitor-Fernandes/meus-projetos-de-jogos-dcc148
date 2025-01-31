using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playercONTROLLER : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f) {
            movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f); 
        }

        if(Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f) {
            movePoint.position += new Vector3(Input.GetAxisRaw("Vertical"), 0f, 0f); 
        }
    }
}

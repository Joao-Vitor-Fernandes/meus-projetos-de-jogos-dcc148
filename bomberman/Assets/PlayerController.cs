using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public List<Sprite> spriteList;
    public float tempoTotalAnimacao = 10f;
    private SpriteRenderer spriteRenderer;
    private float contador = 0f; 
    private int spriteAtual = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * 0.5f;
        float dy = Input.GetAxis("Vertical") * Time.deltaTime * 0.5f;
        
        transform.Translate(dx, dy, 0);

        float tempoSprites = this.tempoTotalAnimacao / this.spriteList.Count;
        if(contador > tempoSprites) {
            this.spriteAtual++;
            if(this.spriteAtual > this.spriteList.Count) {
                this.spriteAtual = 0;
            }
            this.spriteRenderer.sprite = this.spriteList[this.spriteAtual];
            contador = 0f;
        }
        contador += Time.deltaTime;
    }
}

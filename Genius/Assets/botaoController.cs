using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottonScript : MonoBehaviour
{
    private AudioSource audioClip;
    private Light luzPontual;
    private float tempoDecorrido = 0;
    private bool botaoPressionado = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioClip = GetComponent<AudioSource>();

        GameObject luzObj = GameObject.Find("LuzPontual");
        luzPontual = luzObj.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(botaoPressionado){
            tempoDecorrido =+ Time.deltaTime;

            if(tempoDecorrido >= 1){
                luzPontual.enabled = false;
                tempoDecorrido = 0;
                botaoPressionado = false;
            }
        }
    }

    public void PressionaBotao() 
    {
        audioClip.Play();
        luzPontual.gameObject.transform.position = gameObject.transform.position;
        luzPontual.enabled = true;
        botaoPressionado = true;
    }
}

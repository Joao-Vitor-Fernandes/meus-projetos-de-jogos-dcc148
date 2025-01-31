using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject deathCube;
    public GameObject niceCube;

    private GameObject activeCube;
    private int points = 0;
    private float tempoDecorrido = 0;
    private float tempoMax = 5;

    private GameObject deathInstance;
    private GameObject niceInstance;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        activeCube = Instantiate(niceCube);
    }

    // Update is called once per frame
    void Update()
    {
        tempoDecorrido += Time.deltaTime;

        if(tempoDecorrido >= tempoMax)
        {
            points --;
            NewCube();
        }

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            if(activeCube.tag == "Death")
            {
                Debug.Log("Points: " + points);
            }
            else
            {
                points++;
            }

            NewCube();
            Debug.Log("Points: " + points);
        }
    }

    void NewCube()
    {
        tempoDecorrido = 0;

        float randVal = Random.Range(0.0f, 1.0f);
        if(randVal > 0.8)
        {
            activeCube = deathInstance;
            niceInstance.SetActive(false);
            deathInstance.SetActive(true);
        }
        else
        {
            activeCube = niceInstance;
            niceInstance.SetActive(true);
            deathInstance.SetActive(false);
        }

        float randX = Random.Range(-6.0f, 6.0f);
        float randY = Random.Range(-3.0f, 3.0f);
        activeCube.transform.position = new Vector3(randX, randY, 0);
    }
}

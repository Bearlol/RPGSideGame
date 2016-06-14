using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour
{
    public SpriteRenderer[] renderers = new SpriteRenderer[4];
    public GameObject[] classList = new GameObject[4];
    public GameObject[] players = new GameObject[4];
    private int iterator = 0;
    private int playerIterator = 0;

    void Start()
    {
        
        for (int i = 0; i < players.Length; i++)
        {
            renderers[i].sprite = players[i].GetComponent<SpriteRenderer>().sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {       
            if (Input.GetKeyDown("a"))
            {

                iterator++;

                if (iterator == classList.Length)
                {
                    iterator = 0;
                }
                renderers[playerIterator].sprite = classList[iterator].GetComponent<Job>().stillImage;
            }

            if (Input.GetKeyDown("space"))
            {
                players[playerIterator] = classList[iterator];

                Debug.Log(classList[iterator].GetComponent<Job>().name);

                iterator = 0;
            //Once All player characters have been selected, announce player classes
                if (playerIterator == players.Length - 1)
                {
                    for (int i = 0; i < players.Length; i++)
                    {
                          if (players[i])
                          {
                               Debug.Log(players[i].GetComponent<Job>().name);
                          }
                    }
                }
                playerIterator++;
           }
     }    
}

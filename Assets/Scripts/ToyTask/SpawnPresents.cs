using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class SpawnPresents : MonoBehaviour
{
    float presentNum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<GameObject> prizes;
    public GameObject textManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        //instantiate a present based on a random number and add 1 to the counter of the respective present colour located in the text manager game object
        presentNum = Random.Range(0, 10);
        if (presentNum <= 4)
        {
            Instantiate(prizes[0], new Vector2 (0.41f, 0.78f), Quaternion.identity);
            textManager.GetComponent<TextManager>().blueCounter++;
        }else if (presentNum <= 8)
        {
            Instantiate(prizes[1], new Vector2 (0.41f, 0.78f), Quaternion.identity);
            textManager.GetComponent<TextManager>().redCounter++;

        }
        else
        {
            textManager.GetComponent<TextManager>().goldCounter++;
            Instantiate(prizes[2], new Vector2 (0.41f, 0.78f), Quaternion.identity);
        }
        
    }

}

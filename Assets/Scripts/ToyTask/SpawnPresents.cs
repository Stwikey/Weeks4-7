using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class SpawnPresents : MonoBehaviour
{
    float presentNum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<GameObject> prizes;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        presentNum = Random.Range(0, 10);
        if (presentNum <= 4)
        {
            Instantiate(prizes[0], new Vector2 (0.41f, 0.78f), Quaternion.identity);
        }else if (presentNum <= 8)
        {
            Instantiate(prizes[1], new Vector2 (0.41f, 0.78f), Quaternion.identity);
        }
        else
        {
            Instantiate(prizes[2], new Vector2 (0.41f, 0.78f), Quaternion.identity);
        }
        
    }

}

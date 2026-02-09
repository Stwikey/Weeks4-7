using UnityEngine.InputSystem;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class Barrel : MonoBehaviour
{
    public GameObject knifePrefab;
    public GameObject pirate;
    public GameObject knife;
    public List<GameObject> knives;
    public int numOfKnives = 5;
    public Knife knifeScript;
    bool lose = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < numOfKnives; i++)
        {
            int horizontalPos = Random.Range(-1, 1);
            float xpos = 0;
            if (horizontalPos == -1)
            {
                xpos = -1.75f;
            }
            else
            {
                xpos = 1.9f;
            }
                float verticalPos = Random.Range(-3.5f, -0.25f);
            knife = Instantiate(knifePrefab, new Vector2(xpos, verticalPos), Quaternion.identity);
            knives.Add(knife);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (lose)
        {
            for (int i = knives.Count - 1; i >= 0; i--)
            {
                knifeScript = knives[i].GetComponent<Knife>();
                if (knifeScript.destroyed)
                {
                    Destroy(knives[i]);

                    knives.Remove(knives[i]);
                    int safe = Random.Range(-1, 1);
                    if (safe == -1)
                    {
                        lose = false;
                        pirate.SetActive(true);
                    }
                }
            }
        }


    }  
}

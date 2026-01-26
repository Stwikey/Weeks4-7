using UnityEngine;
using UnityEngine.InputSystem;
public class Spawner : MonoBehaviour
{

    public GameObject spritePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void spawnDuck()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-10, 10), Random.Range(-5, 5));
        Instantiate(spritePrefab, spawnPos, Quaternion.identity);
    }
}

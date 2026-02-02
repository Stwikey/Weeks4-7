using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    SpriteRenderer spriteRenderer;
    public Slider rotation;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 turn = new Vector3(0, 1, 0);
        turn.z = rotation.value;
        transform.eulerAngles = turn;
    }

    public void randomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
        
    }
}

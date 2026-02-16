using UnityEngine;
using UnityEngine.UI;

public class ClawMovement : MonoBehaviour
{
    public Slider movement;
    public float farRight;
    public float farLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement.maxValue = farRight;
        movement.minValue = farLeft;
        movement.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 horizontalPos = new Vector2(movement.value, 3.5f);
        transform.localPosition = horizontalPos;
    }
}

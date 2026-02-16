using UnityEngine;
using UnityEngine.UI;

public class ClawMovement : MonoBehaviour
{
    public Slider movement;
    public float farRight;
    public float farLeft;

    public float topPos = 3.5f;
    public float bottomPos = -1f;
    public float t = 0f;
    public bool grab = false;
    public float verticalPos = 3.5f;

    public AnimationCurve curve;
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
        if (grab)
        {
            t += Time.deltaTime;
            verticalPos = Mathf.Lerp(topPos, bottomPos, curve.Evaluate(t));

            if (t > 1f)
            {
                grab = false;
                verticalPos = 3.5f;
            }

        }

        Vector2 horizontalPos = new Vector2(movement.value, verticalPos);
        transform.localPosition = horizontalPos;
    }

    public void GrabPresent()
    {
        grab = true;
        t = 0f;
    }
}

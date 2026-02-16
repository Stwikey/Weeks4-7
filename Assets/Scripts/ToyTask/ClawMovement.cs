using UnityEngine;
using UnityEngine.UI;

public class ClawMovement : MonoBehaviour
{
    //declaring variables for the horizontal movement function
    public Slider movement;
    public float farRight;
    public float farLeft;

    //declaring variables for the verical movement (grabbing) function
    public float topPos = 3.5f;
    public float bottomPos = -1f;
    public float t = 0f;
    public bool grab = false;
    public float verticalPos = 3.5f;
    public AnimationCurve curve;

    //declaring variables for the rotation function
    public Slider rotation;

    public GameObject presentSpawner;

    public SpawnPresents spawnerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        //setting slider values
        movement.maxValue = farRight;
        movement.minValue = farLeft;
        movement.value = 0;
        rotation.maxValue = 720;
        rotation.minValue = 0;
        //getting a reference to the sprite renderer
        spriteRenderer = GetComponent<SpriteRenderer>();

        //getting a reference to the script that can spawn presents
        spawnerScript = presentSpawner.GetComponent<SpawnPresents>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if the grab button has been pushed
        if (grab)
        {
            //if it has, start a timer for lerping the vertical movement
            t += Time.deltaTime;

            //move the claw down based on the timer and animation curve
            verticalPos = Mathf.Lerp(topPos, bottomPos, curve.Evaluate(t));

            //if the claw has reached the bottom
            if (t > 1f)
            {
                //spawn a present
                if (spawnerScript != null)
                {
                    spawnerScript.Spawn();
                }

                //set the claw back to default position
                grab = false; 
                verticalPos = 3.5f;
            }

        }

        //rotate the claw's y rotation based on a slider
        Vector3 rotatePos = Vector3.zero;
        rotatePos.y = rotation.value;
        transform.eulerAngles = rotatePos;

        //move the claw's horizontal position based on a slider
        Vector2 horizontalPos = new Vector2(movement.value, verticalPos);
        transform.localPosition = horizontalPos;
    }


    //function to tell the claw to grab a present when a button has been pressed
    public void GrabPresent()
    {
        grab = true;
        t = 0f;
    }
}

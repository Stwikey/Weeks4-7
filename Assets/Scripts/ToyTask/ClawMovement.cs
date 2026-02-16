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

    public Slider rotation;
    SpriteRenderer spriteRenderer;

    public AnimationCurve curve;
    public GameObject presentSpawner;

    public SpawnPresents spawnerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement.maxValue = farRight;
        movement.minValue = farLeft;
        movement.value = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        rotation.maxValue = 720;
        rotation.minValue = 0;
        spawnerScript = presentSpawner.GetComponent<SpawnPresents>();
        
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
                if (spawnerScript != null)
                {
                    spawnerScript.Spawn();
                }

                grab = false; 
                verticalPos = 3.5f;
            }

        }
        Vector3 rotatePos = Vector3.zero;
        rotatePos.y = rotation.value;
        transform.eulerAngles = rotatePos;


        Vector2 horizontalPos = new Vector2(movement.value, verticalPos);
        transform.localPosition = horizontalPos;
    }

    public void GrabPresent()
    {
        grab = true;
        t = 0f;
    }
}

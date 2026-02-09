using UnityEngine;
using UnityEngine.InputSystem;

public class Knife : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    SpriteRenderer spriteRenderer;
    public bool destroyed = false;
    void Start()
    {
        if (transform.position.x < 2f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
        if (transform.position.x < 1f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (Mouse.current.leftButton.wasPressedThisFrame && spriteRenderer.bounds.Contains(mousePos))
        {
            destroyed = true;
        }

    }


}

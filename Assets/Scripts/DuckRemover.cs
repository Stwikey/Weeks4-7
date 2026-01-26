using UnityEngine;
using UnityEngine.InputSystem;
public class DuckRemover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (Mouse.current.leftButton.wasPressedThisFrame == true && spriteRenderer.bounds.Contains(mousepos)== true)
        {
            Destroy(gameObject);

           
        }
    }


}

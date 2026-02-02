using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class Information : MonoBehaviour
{
    public string description = "";
    public TextMeshProUGUI desc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (mousePos.x > transform.position.x - 2 && mousePos.x < transform.position.x + 2 && mousePos.y > transform.position.y - 2 && mousePos.y < transform.position.y + 2)
        {
            Debug.Log(description);
            desc.text = description; 
        }
    }
}

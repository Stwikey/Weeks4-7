using UnityEngine;

public class Toggle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleBird()
    {
        Debug.Log("Toggle the bird please");
        //gameObject.SetActive(false); //SetActive sets the value
        //gameObject.activeInHierarchy //this tells us if the box is ticked

        //if the bird is active, call SetActive and pass false
        //if (gameObject.activeInHierarchy == true)
        //{
            //gameObject.SetActive(false);
        //}
        //else if (gameObject.activeInHierarchy == false)
        //{
            //(otherwise) if the bird is not active, call SetActive and pass true
            //gameObject.SetActive(true);
        //}

        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    //keeping track of the text and counters of each present colour
    public string redDesc = "";
    public string blueDesc = "";
    public string goldDesc = "";

    public TextMeshProUGUI Red;
    public TextMeshProUGUI Blue;
    public TextMeshProUGUI Gold;

    public int redCounter = 0;
    public int blueCounter = 0;
    public int goldCounter = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    //update the text displayed based on the counter of the presents
    void Update()
    {
        redDesc = "Red Presents: " + redCounter;
        blueDesc = "Blue Presents: " + blueCounter;
        goldDesc = "Gold Presents: " + goldCounter;

        Red.text = redDesc;
        Blue.text = blueDesc;
        Gold.text = goldDesc;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text newText;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is Michael Colon!"; // replace my name with your actual name, a nickname, or whatever name you prefer to use
            newText.fontSize = 38;
        }

        if (Input.GetKeyDown("e"))
        {
            newText.text = "Congratulations! You pressed E!";
            newText.fontSize = 33;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Blebber : MonoBehaviour
{
    public TextMeshProUGUI lineUI;

    private Canvas dialogueCanvas;
    // Start is called before the first frame update
    void Start()
    {
        dialogueCanvas = lineUI.canvas; 
        dialogueCanvas.enabled = false;
    }

    public void StartTalking()
    {
        dialogueCanvas.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

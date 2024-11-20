using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class mAnimation : MonoBehaviour
{
public InputActionAsset matildasPlayerAction;
public Animator matildasAnimator;

    // Start is called before the first frame update
    void Start()
    {
        if (matildasPlayerAction.FindAction("Run").IsPressed())
        {
            matildasAnimator.SetBool("runanimation", true);
        }
        else 
        matildasAnimator.SetBool("runanimation",false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

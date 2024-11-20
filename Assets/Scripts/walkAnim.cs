using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class walkAnim : MonoBehaviour
{
    public InputActionAsset playerAction;
    public Animator walkAnimation;
    void Update()
    {
        if (playerAction.FindAction("Move").IsPressed())
        {
            walkAnimation.SetBool("isWalk",true);
        }
        else
        {
            walkAnimation.SetBool("isWalk",false);
        }
    }
}

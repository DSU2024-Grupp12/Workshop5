using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameField;
    public TMP_Text dialogueField;
    
    private Queue<string> sentences;

    public Animator animator;
    
    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    { 
        animator.SetBool("isOpen",true);
        
        nameField.text = dialogue.name;
        
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            animator.SetBool("isOpen",false);
            EndDialogue();
            return;
        }
        
        string sentence = sentences.Dequeue();
        dialogueField.text = sentence;
    }
    
    private void EndDialogue()
    {
        Debug.Log("ending dialogue");
    }
}


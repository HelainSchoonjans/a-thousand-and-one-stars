using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI display;
    public string[] sentences;
    private int index;
    public float typingSpeed = 0.02f;

    public GameObject continueButton;
    public Animator displayAnimator;
    public GameObject dialogBackground;

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            display.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        displayAnimator.SetTrigger("Change");
        continueButton.SetActive(false);
        if( index < sentences.Length - 1)
        {
            index++;
            StopAllCoroutines();
            display.text = "";
            StartCoroutine(Type());
        } else
        {
            End();
        }
    }

    public void End()
    {
        display.text = "";
        continueButton.SetActive(false);
        dialogBackground.SetActive(false);
    }
    
    void Start()
    {
        //NextSentence();
        StartCoroutine(Type());
    }

    // Update is called once per frame
    void Update()
    {
        if(display.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }
}

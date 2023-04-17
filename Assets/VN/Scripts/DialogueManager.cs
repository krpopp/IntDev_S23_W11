using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public List<string> allDialogue = new List<string>();

    int currentLine = 0;

    [SerializeField] TMP_Text dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDialogueText();
    }

    public void ContinueDialogue()
    {
        if (currentLine < allDialogue.Count - 1)
        {
            currentLine++;
            UpdateDialogueText();
        }
    }

    void UpdateDialogueText()
    {
        dialogueText.text = allDialogue[currentLine];
    }
}

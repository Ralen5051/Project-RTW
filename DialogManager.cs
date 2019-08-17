using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using gameGlobals;

public class DialogManager : MonoBehaviour
{
    DialogueStorage Storage;
    public Text dialogueTextBox;
    public Text speakerNameTextBox;
    public string searchterm;
    private int clickID;
    public dialogueData initialDialogue;
    public void option1()
    {
        clickID = 1;
    }

    private void Start()
    {
        Storage = GetComponent<DialogueStorage>();  
        
    }
    public void searchCharacterToTalkTo()
    {

    }
    public void searchdialogue()
    {

      
                for (int i = 0; i < (Storage.farmerDialogueData.Length-1); ++i)
                {
                    
                }
               
        
    }
    public void loadResponse(dialogueData dialogue)
    {
        dialogueTextBox.text = dialogue.Dialogue;
        speakerNameTextBox.text = dialogue.Name;

    }
}

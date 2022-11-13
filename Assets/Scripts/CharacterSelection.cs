using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] character;
    public static int selectedCharacter;

    private void Awake()
    {
        selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
        foreach (GameObject player in character)
            player.SetActive(false);

        character[selectedCharacter].SetActive(true);
    }

    public void ChangeNext()
    {
        character[selectedCharacter].SetActive(false);
        if (selectedCharacter < 4)
        {
            selectedCharacter++;
            if (selectedCharacter == -1)
            {
                selectedCharacter = 3;
            }
            else if(selectedCharacter == 4)
            {
                selectedCharacter = 0;
            }
        }
        else if (selectedCharacter < 7 && selectedCharacter > 3)
        {
            selectedCharacter++;
            if(selectedCharacter == 7)
            {
                selectedCharacter = 4;
            }
            else if(selectedCharacter == 3)
            {
                selectedCharacter = 6;
            }
        }
        else if (selectedCharacter < 10 && selectedCharacter > 6)
        {
            selectedCharacter++;
            if(selectedCharacter == 10)
            {
                selectedCharacter = 7;
            }
            else if (selectedCharacter == 6)
            {
                selectedCharacter = 9;
            }
        }

        character[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
    }

    public void ChangePrevious()
    {
        character[selectedCharacter].SetActive(false);
        if (selectedCharacter < 4)
        {
            selectedCharacter--;
            if (selectedCharacter == -1)
            {
                selectedCharacter = 3;
            }
        }
        else if (selectedCharacter < 7 && selectedCharacter > 3)
        {
            selectedCharacter--;
            if(selectedCharacter == 7)
            {
                selectedCharacter = 4;
            }
            else if(selectedCharacter == 3)
            {
                selectedCharacter = 6;
            }
        }
        else if (selectedCharacter < 10 && selectedCharacter > 6)
        {
            selectedCharacter--;
            if(selectedCharacter == 10)
            {
                selectedCharacter = 7;
            }
            else if (selectedCharacter == 6)
            {
                selectedCharacter = 9;
            }
        }

        character[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);    
    }

    public void airshipSelect()
    {
        character[selectedCharacter].SetActive(false);
        selectedCharacter = 0;

        character[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);  
    }

    public void airplaneSelect()
    {
        character[selectedCharacter].SetActive(false);
        selectedCharacter = 7;

        character[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);  
    }

    public void helicopterSelect()
    {
        character[selectedCharacter].SetActive(false);
        selectedCharacter = 4;

        character[selectedCharacter].SetActive(true);
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);  
    }
}

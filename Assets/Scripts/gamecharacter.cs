using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecharacter : MonoBehaviour
{
    public GameObject[] character;
    public int selectedCharacter;

    private void Awake()
    {
        selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", CharacterSelection.selectedCharacter);
        foreach (GameObject player in character)
            player.SetActive(false);

        character[selectedCharacter].SetActive(true);
    }
}

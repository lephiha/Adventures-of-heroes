using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    private int index;
    [SerializeField] GameObject[] characters;
    void Start()
    {
        index = 0;
    }

    public void OnPlayBtnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnPrevBtnClick()
    {
        if (index > 0)
        {
            index--;
            SelectCharacter();
        }
        SelectCharacter();
    }
    public void OnNextClick()
    {
        if (index > 0)
        {
            index++;
        }
        SelectCharacter();
    }

    private void SelectCharacter()
    {
        for (int i =0; i < characters.Length;i++)
        {
            if(i == index)
            {
                characters[i].GetComponent<SpriteRenderer>().color = Color.white;
                characters[i].GetComponent<Animator>().enabled = true;
            }
            else
            {
                characters[i].GetComponent<SpriteRenderer>().color = Color.black;
                characters[i].GetComponent<Animator>().enabled = false;
            }
        }
    }
}

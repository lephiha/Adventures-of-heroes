using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button[] buttons;
    public GameObject levelButtons;


    private void Awake()
    {
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        UpdateButtonInteractivity(unlockedLevel);
    }

    private void UpdateButtonInteractivity(int unlockedLevel)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = (i < unlockedLevel);
        }
    }

    public void OpenScene(int levelId)
    {
        string levelName = "Level " + levelId;
        SceneManager.LoadScene(levelName);
    }
}
 

    //void ButtonsToArray()
   // {
    //    int childCount = levelButtons.transform.childCount;
    //    buttons = new Button[childCount];
    //    for (int i = 0; i < childCount; i++)
    //    {
    //        buttons[i] = levelButtons.transform.GetChild(i).gameObject.GetComponent<Button>();
    //    }
    //}


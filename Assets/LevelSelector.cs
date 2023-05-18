using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    [SerializeField] public string nameLevel;

    public void OpenScene()
    {
        if (nameLevel == "Advanced")
        {
            SceneManager.LoadScene("Advanced");
        }
        else if (nameLevel == "Normal")
        {
            SceneManager.LoadScene("Normal");
        }
        else if (nameLevel == "Easy")
        {
            SceneManager.LoadScene("Easy");
        }
    }

}

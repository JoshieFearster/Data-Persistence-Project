using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI playerName;

    public void StartButton()
    {
        ScoreManager.Instance.Name = playerName.text;
        SceneManager.LoadScene(1);
    }
}

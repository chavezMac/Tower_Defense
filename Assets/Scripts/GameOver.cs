using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI roundsText;

    void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }

    public void Retry()
    {
        GameManager.GameIsOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Debug.Log("Go to Menu");
    }
}

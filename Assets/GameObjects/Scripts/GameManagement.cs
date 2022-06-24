using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    bool gameHasEnded = false;
    public float EndingGameLag = 1f;

    public GameObject CompleteLevelUI;

    // Update is called once per frame
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", EndingGameLag);
        }
    }

    public void GameComplete()
    {
        CompleteLevelUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float restartDelay = 1f;
    
    public GameObject LevelCompeleteUI;
   
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Endgame");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
}

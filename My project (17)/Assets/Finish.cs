
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
public GameObject LevelCompleteUI;
public void CompleteLevel()
    {
        LevelCompleteUI.SetActive(true);
    }
    
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.tag=="Player")
        {

            CompleteLevel();
            
        
        }
    }
}

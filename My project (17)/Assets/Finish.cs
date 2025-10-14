
using UnityEngine;

public class Finish : MonoBehaviour
{
      public void CompleteLevel()
    {
        Debug.Log("You won");
    }
    void OnTriggerEnter()
    {
        CompleteLevel();
    }
}

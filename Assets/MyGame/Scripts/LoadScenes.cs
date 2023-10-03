using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ChangeScene(string newScene)
    {
      
        SceneManager.LoadScene(newScene);
    }
}

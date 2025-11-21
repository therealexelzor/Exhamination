using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void GoToSceneTwo()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void GoToSceneThree()
    {
        SceneManager.LoadScene("Story");
    }
    
}
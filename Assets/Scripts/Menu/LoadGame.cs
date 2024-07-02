using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void OpenGame()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0)) 
        {
            OpenGame();
        }
    }
}

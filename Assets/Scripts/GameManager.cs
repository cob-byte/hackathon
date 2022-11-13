using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;
    
      public void Start (){
        Time.timeScale = 1;
    }
    public void GameOver(){
         gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Game Over.");
    }

    public void Replay(){
        SceneManager.LoadScene(3);
    }

    public void Home(){
        SceneManager.LoadScene(2);
    }

}

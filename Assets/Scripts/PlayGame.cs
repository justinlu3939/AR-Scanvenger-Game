using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void TutorialScene()
    {
        //you will have to manually reset the counters to any objects
        ScoreManager.scoreCounter = 0;
        ScoreManager.meatCounter = 0;
        ScoreManager.avCounter = 0;
        ScoreManager.milkCounter = 0;
        ScoreManager.sodaCounter = 0;
        ScoreManager.time = 100f;
        SceneManager.LoadSceneAsync(0);
    }
    public void PlayTheGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void GoToInventory()
    {
        SceneManager.LoadSceneAsync(2);
    }
}

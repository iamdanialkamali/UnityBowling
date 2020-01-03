using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainCamera;
    public GameConfig GameConfig;

    public void PlayGame()
    {
        mainCamera.SetActive(false);
    }
    public void ExitGame ()
    {
        Application.Quit();
    }

    public void adClick()
    {
        if (ServiceLocator.Instance.adManager.showAd())
        {
            ServiceLocator.Instance.eventManager.Propagate(new GameEvent(GameConfig.AdPoint));
        }
    }
    
}

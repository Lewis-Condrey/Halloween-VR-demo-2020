using UnityEngine;
using UnityEngine.SceneManagement;

public class PcMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene("PcMenu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Site()
    {
        Application.OpenURL("http://twiz.xyz");
    }


}

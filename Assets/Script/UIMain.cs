using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene("Fare Oynu111");
    }
    public void multiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }
    public void ai()
    {
        SceneManager.LoadScene("Pcye Karsi");
    }
    public void quit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    
}

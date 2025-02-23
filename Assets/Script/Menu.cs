using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ZacznijGre()
    {
        SceneManager.LoadScene(1);
    }

    public void ZamknijGre()
    {
        Application.Quit();
    }
}

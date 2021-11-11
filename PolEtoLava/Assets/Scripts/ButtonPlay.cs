using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("DemoScene");
    }

    void Exit()
    {
        if (Input.GetKeyDown("escape")) Application. Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    public void OnEscape()
    {
        SceneManager.LoadScene(0);
    }
}

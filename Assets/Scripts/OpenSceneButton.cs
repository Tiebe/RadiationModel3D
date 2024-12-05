using System;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenSceneButton : MonoBehaviour
{
    public ModelScenes targetScene;
    public Button button;

    private void Start()
    {
        if (button == null)
        {
            button = GetComponent<Button>();
        }
        
        button.onClick.AddListener(OpenScene);
    }

    public void OpenScene()
    {
        SceneManager.LoadScene((int)targetScene);
    }
    
    // defined in build list scene profile
    public enum ModelScenes
    {
        MainMenu,
        Vervalbeta,
        BetaAfstand,
        AbsorbtieGamma,
        AbsorbtieBeta,
    }
}

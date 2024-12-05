using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Start()
    {
        if (text == null)
        {
            text = GetComponent<TextMeshProUGUI>();
        }
    }

    public void SetText(string newText)
    {
        if (text == null)
        {
            Debug.LogWarning("Text is null");
            return;
        }
        text.text = "<mspace=1.3em>"+newText+"</mspace>";
    }
}

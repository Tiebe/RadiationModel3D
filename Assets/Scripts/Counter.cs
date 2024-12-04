using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        if (text == null)
        {
            text = GetComponent<TextMeshProUGUI>();
        }
    }

    public void SetText(string newText)
    {
        text.text = "<mspace=1.3em>"+newText+"</mspace>";
    }
}

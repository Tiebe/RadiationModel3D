using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button button;
    public TMP_InputField inputField;
    public RadiationEmitter emitter;
    
    private void Start()
    {
        if (button == null)
        {
            button = GetComponent<Button>();
        }
        button.onClick.AddListener(OnClick);

        if (inputField == null)
        {
            inputField = transform.parent.GetComponentInChildren<TMP_InputField>();
        }

        if (emitter == null)
        {
            emitter = GameObject.FindWithTag("Emitter").GetComponent<RadiationEmitter>();
        }

        inputField.text = emitter.initalAmount.ToString();
    }

    private void OnClick()
    {
        if (!emitter.emitting)
        {
            if (inputField.text.Length != 0)
            {
                emitter.initalAmount = Int32.Parse(inputField.text);
            }

            inputField.readOnly = true;
            
            emitter.emitting = true;
            
            emitter.Emit();
        }
    }
}

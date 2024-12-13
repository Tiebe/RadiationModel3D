using System.Linq;
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

        inputField.text = emitter.startingSubstancesList.First().amount.ToString();
    }

    private void OnClick()
    {
        if (!emitter.emitting)
        {
            if (inputField.text.Length != 0)
            {
                var substance = emitter.startingSubstancesList[0];
                substance.amount = long.Parse(inputField.text);
                emitter.startingSubstancesList[0] = substance;
            }

            // TODO add method for this to be set to false when the experiment finishes
            inputField.readOnly = true;
            
            emitter.emitting = true;
            
            emitter.Emit();
        }
    }
}

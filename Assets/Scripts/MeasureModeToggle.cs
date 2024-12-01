using UnityEngine;
using UnityEngine.UI;

public class MeasureModeToggle : MonoBehaviour
{
    public Toggle toggle;
    public RadiationEmitter emitter;

    public Manager managerWhenOff;
    public Manager managerWhenOn;

    private void Start()
    {
        if (toggle == null)
        {
            toggle = GetComponent<Toggle>();
        }
        toggle.onValueChanged.AddListener(OnToggle);

        // if the manager mode is set to a value that is neither toggle on nor toggle of that will lead to unexpected behaviour
        toggle.isOn = managerWhenOff.enabled;

        if (emitter == null)
        {
            emitter = GameObject.FindWithTag("Emitter").GetComponent<RadiationEmitter>();
        }
    }

    // TODO use something other than update to optimise
    private void Update()
    {
        toggle.interactable = !emitter.emitting;
    }

    void OnToggle(bool value)
    {
        switch (value)
        {
            case false:
                managerWhenOn.enabled = false;
                managerWhenOff.enabled = true;
                break;
            case true:
                managerWhenOff.enabled = false;
                managerWhenOn.enabled = true;
                break;
        }
    }
}

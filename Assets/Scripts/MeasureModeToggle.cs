using System;
using UnityEngine;
using UnityEngine.UI;

public class MeasureModeToggle : MonoBehaviour
{
    public Toggle toggle;
    public Manager manager;
    public RadiationEmitter emitter;
    public Manager.Modes toggleOff;
    public Manager.Modes toggleOn;
    void Start()
    {
        if (toggle == null)
        {
            toggle = GetComponent<Toggle>();
        }
        toggle.onValueChanged.AddListener(OnToggle);

        if (manager == null)
        {
            manager = GameObject.FindWithTag("Manager").GetComponent<Manager>();
        }

        // if the manager mode is set to a value that is neither toggle on nor toggle of that will lead to unexpected behaviour
        toggle.isOn = manager.currentMode == toggleOn;

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
                manager.currentMode = toggleOff;
                break;
            case true:
                manager.currentMode = toggleOn;
                break;
        }
    }
}

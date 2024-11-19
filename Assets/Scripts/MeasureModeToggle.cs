using System;
using managers;
using UnityEngine;
using UnityEngine.UI;

public class MeasureModeToggle : MonoBehaviour
{
    public Toggle toggle;
    public GameObject manager;
    public RadiationEmitter emitter;
    void Start()
    {
        if (toggle == null)
        {
            toggle = GetComponent<Toggle>();
        }
        toggle.onValueChanged.AddListener(OnToggle);

        if (manager == null)
        {
            manager = GameObject.FindWithTag("Manager");
        }

        // if the manager mode is set to a value that is neither toggle on nor toggle of that will lead to unexpected behaviour
        toggle.isOn = manager.GetComponent<IntervalManager>().enabled;

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
                manager.GetComponent<IntervalManager>().enabled = false;
                manager.GetComponent<DefaultRadiationManager>().enabled = true;
                break;
            case true:
                manager.GetComponent<DefaultRadiationManager>().enabled = false;
                manager.GetComponent<IntervalManager>().enabled = true;
                break;
        }
    }
}

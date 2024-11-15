using System;
using UnityEngine;
using UnityEngine.UI;

public class MeasureModeToggle : MonoBehaviour
{
    public Toggle toggle;
    public Manager manager;
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
            manager = GameObject.FindWithTag("Manager").GetComponent<Manager>();
        }

        if (emitter == null)
        {
            emitter = GameObject.FindWithTag("Emitter").GetComponent<RadiationEmitter>();
        }
    }

    private void Update()
    {
        toggle.interactable = !emitter.emitting;
    }

    void OnToggle(bool value)
    {
        manager.tenSecMode = value;
    }
}

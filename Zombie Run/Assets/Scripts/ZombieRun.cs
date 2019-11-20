using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieRun : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State currentState;

    void Start()
    {
        currentState = startingState;
        textComponent.text = currentState.GetStateStory();
    }

    void Update()
    {
        MenageState();
    }

    private void MenageState()
    {
        var nextStates = currentState.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = nextStates[0];

        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = nextStates[1];

        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentState = nextStates[2];

        }

        textComponent.text = currentState.GetStateStory();
    }
}

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
        
    }
}

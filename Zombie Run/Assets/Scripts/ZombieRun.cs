using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieRun : MonoBehaviour
{
    [SerializeField] Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = ("The game starting text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

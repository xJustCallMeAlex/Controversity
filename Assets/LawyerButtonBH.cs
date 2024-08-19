using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LawyerButtonBH : MonoBehaviour
{
    public GameStateBH gameStateBH;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameStateBH != null)
        {
            gameStateBH.lawyerButtonClicked();
        }
    }
}

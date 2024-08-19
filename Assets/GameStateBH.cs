using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateBH : MonoBehaviour
{

    public GameObject startScreen;
    public GameObject ytButton;
    public GameObject twitterButton;
    public GameObject lawyerButton;
    private bool isStartScreenVisible = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isStartScreenVisible)
        {
            startScreen.SetActive(false);
            isStartScreenVisible = false;
        }

        
    }

    public void yTButtonClicked()
    {
        ytButton.SetActive(false);
        twitterButton.SetActive(false);
        lawyerButton.SetActive(false);
    }

    public void twitterButtonClicked()
    {
        ytButton.SetActive(false);
        twitterButton.SetActive(false);
        lawyerButton.SetActive(false);
    }

    public void lawyerButtonClicked()
    {
        ytButton.SetActive(false);
        twitterButton.SetActive(false);
        lawyerButton.SetActive(false);
    }
}

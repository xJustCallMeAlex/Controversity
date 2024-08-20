using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public Animator animator;

    private int levelToLoad;


    void Update()
    {
        if (Input.anyKeyDown)
        {
            FadeToNextScene();
        }
    }

    public void FadeToNextScene() 
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel (int levelIndex) 
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("Fade_Out");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex; 
    [SerializeField] int waitTime = 4; 
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex; 
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime()); 
        }
        
    }
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(waitTime);
        LoadNextScene(); 
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1); 
    }

}

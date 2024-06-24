using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;

public class GameManagerStrict : MonoBehaviour
{
    
    public string nowSceneName;

    public string nextSceneName;

    public string TitleReturn;

    public bool v;




    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1280, 720, false);
    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && nextSceneName == "SampleScene")
        {
            SceneManager.LoadScene(nextSceneName);
        }


        if (v == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }



        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(nowSceneName);
        }


        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(TitleReturn);
        }
    }
}

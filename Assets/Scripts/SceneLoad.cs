using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    
    void Start()
    {
        Test();
    }

    void Update()
    {
        
    }

    public void SceneLoading()
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("22222");
    }

    void Test()
    {
        Debug.Log(1);
    }
}

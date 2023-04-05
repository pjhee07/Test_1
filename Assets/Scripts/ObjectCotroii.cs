using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCotroii : MonoBehaviour
{
    [SerializeField] private GameObject gamePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gamePanel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            gamePanel.SetActive(false);
        }
    }
}

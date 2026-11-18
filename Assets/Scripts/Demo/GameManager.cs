using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void onButtonClick(GameObject buttonObject)
    {
        Debug.Log(buttonObject.name + " Click.");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    // Start is called before the first frame update
    public int sceneToLoad;     // Load corridor by default
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void OnUserSelectExit()
    {
        Debug.Log("SelectExit -> Door");
        SceneManager.LoadScene(sceneToLoad);
    }
}

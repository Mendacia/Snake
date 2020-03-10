using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{

    private int snakesCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (snakesCollected == 7)
        {
            SceneManager.LoadScene("winScreen", LoadSceneMode.Single);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            snakesCollected++;
        }
    }
}

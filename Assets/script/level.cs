using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level : MonoBehaviour
{
    private int levels;


    private void Start()
    {
       
         levels = SceneManager.GetActiveScene().buildIndex  +1;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(levels);
    }
}

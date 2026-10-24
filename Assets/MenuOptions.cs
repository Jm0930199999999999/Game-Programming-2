using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene"); //change the name of the scene in the speech marks to match your scene name 
    }
}

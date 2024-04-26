using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class MenuScript : MonoBehaviour
{
    public void menu(){
        SceneManager.LoadScene(1);
    }
     public void psant(){
        SceneManager.LoadScene(2);
    }
    
    public void hvh(){
        SceneManager.LoadScene(3);
    }

    public void aivsh(){
        SceneManager.LoadScene(3);
    }
     public void pdama(){
        SceneManager.LoadScene(4);
    }

     public void pxox(){
        SceneManager.LoadScene(7);
    }

    public void pxoxgame(){
                SceneManager.LoadScene(8);

    }

    public void exit(){
        Application.Quit();
    }
 }

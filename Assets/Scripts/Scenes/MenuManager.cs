﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OpenScene(int index){
        SceneManager.LoadScene(index);
    }

    public void ExitGame(){
        Application.Quit();
    }
}

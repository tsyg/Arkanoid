using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Arkanoid 
{

    public static ArkanoidConfig config;

    static Arkanoid() {
        config = Resources.Load<ArkanoidConfig>("Config");
    }

    public static void Loadlevel(int levelNumber) {
        SceneManager.LoadScene("Level");
    }

    // public static void StartNewGame() {
    //     SceneManager.LoadScene("Level:1:easy:red");
    // }


////  -----------------   dbg


    public static void Action(string cmd) {
        string [] arguments = cmd.Split(':');
        SceneManager.LoadScene(arguments[0]);
    }
}

//  TODO
// Resources - Load
// Scriptabe object
/// ... Instantiate   


// TODO Dec19 -->>  Convert string into integer arrays..  See files..
/*
  TextAssets
Int []  - to generate our objects;


*/
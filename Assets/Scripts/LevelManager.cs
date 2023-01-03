using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" ***** LevelManager.Start --beg ***********");
        // string data = System.IO.File.ReadAllText(
        //     @"/home/universe.dart.spb/tsyg/Learning/Ark/Arkanoid/Assets/Levels/level9.txt");
        // ArkanoidConfigLevel.parseLevelData(data);
        // Debug.Log(" ***** LevelManager. before Instantiate");

        GameObject newBrick = Instantiate(Arkanoid.config.brickPrefab);
        newBrick.transform.SetParent(this.transform);
        Vector3 pos = newBrick.transform.position; 
        Debug.Log(" ***** LevelManager. A: " + pos.ToString());
        // newBrick.transform.position = Vector3.zero;
        // Debug.Log(" ***** LevelManager.Start --002");
        // BrickPrefab brickPrefabScript = newBrick.GetComponent<BrickPrefab>();
        // Debug.Log(" ***** LevelManager.Start --end ...........");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

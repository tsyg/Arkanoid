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

        // Generte bricks for the level (the one we've set and copied)
        createBricks(Arkanoid.config.levels[0].GetLevelData());
        Debug.Log(" ***** LevelManager - Level created");
    }


    private void createBricks(List<List<int>> levelData){
        int iline = 0;
        float dx = 2.2f; // Arkanoid.config.brickPrefab.
        float dy = 0.6f; 
        int ny = levelData.Count;
        foreach (List<int> line in levelData) {
            int icell = 0;
            int nx = line.Count;
            foreach (int cell in line) {
                // Debug.Log("Line, cell: ["+iline.ToString()+","+ icell.ToString() +"]  " 
                // + cell.ToString());
                
                if (cell!=0) {  // a brick must be created
                    GameObject newBrick = Instantiate(Arkanoid.config.brickPrefab);
                    newBrick.transform.SetParent(this.transform);
                    Vector3 pos = Vector3.zero;
                    pos.x = dx * (icell - nx/2);
                    pos.y = dy * (iline - ny/2);
                    newBrick.transform.position = pos;
                    // Color from palette                    
                }


                icell++;
            }
            iline++;
        }

    }
    /*
        GameObject newBrick = Instantiate(Arkanoid.config.brickPrefab);
        newBrick.transform.position = Vector3.zero;
        BrickPrefab brickPrefabScript = newBrick.GetComponent<BrickPrefab>();

    */

    // Update is called once per frame
    void Update()
    {
        
    }
}

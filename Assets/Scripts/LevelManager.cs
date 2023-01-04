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
        // Debug.Log(" ***** LevelManager. before Instantiate");

        GameObject newBrick = Instantiate(Arkanoid.config.brickPrefab);
        newBrick.transform.SetParent(this.transform);
        Vector3 pos = newBrick.transform.position; 
        //Debug.Log(" ***** LevelManager. A: " + pos.ToString());
        // newBrick.transform.position = Vector3.zero;
        // Debug.Log(" ***** LevelManager.Start --002");
        // BrickPrefab brickPrefabScript = newBrick.GetComponent<BrickPrefab>();
        // Debug.Log(" ***** LevelManager.Start --end ...........");
    }


    private void createBricks(List<List<int>> levelData){
        int iline = 0;
        //float dx = Arkanoid.config.brickPrefab.
        foreach (List<int> line in levelData) {
            int icell = 0;
            foreach (int cell in line) {
                Debug.Log("Line, cell: ["+iline.ToString()+","+ icell.ToString() +"]  " 
                //+ line.ToString() + " " 
                + cell.ToString());

                GameObject newBrick = Instantiate(Arkanoid.config.brickPrefab);
                newBrick.transform.SetParent(this.transform);
                // Vector3 pos = newBrick.transform.position; 
                // pos.x += 

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

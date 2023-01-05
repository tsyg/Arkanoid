using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public int currentLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" ***** LevelManager.Start --beg ***********");
        // string data = System.IO.File.ReadAllText(
        //     @"/home/universe.dart.spb/tsyg/Learning/Ark/Arkanoid/Assets/Levels/level9.txt");

        if (Arkanoid.arguments.Length > 0) {
            currentLevel = int.Parse(Arkanoid.arguments[1]);
        }
        

        // Generte bricks for the level (the one we've set and copied)
        createBricks(Arkanoid.config.levels[currentLevel].GetLevelData());
        Debug.Log(" ***** LevelManager - Level created");
    }


    private void createBricks(List<List<int>> levelData){
        int iline = 0;
        float dx = 2.2f; //transform.localScale.x + 0.2f; // TODO - find out What's wrong with scale using
        float dy = 0.6f; //transform.localScale.y + 0.1f;  
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
                    pos.y = dy * (ny/2 - iline);  // 0 is at the top
                    newBrick.transform.position = pos;

                    // Color from palette    
                    Renderer mr = newBrick.GetComponent<Renderer>();
                    Debug.Assert(
                        cell < Arkanoid.config.bricksPalette.Length,
                        "there must be enough colors in palette, at least " + cell.ToString());
                    mr.material.color = Arkanoid.config.bricksPalette[cell];
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Config", menuName = "Arkanoid/Config")]
public class ArkanoidConfig : ScriptableObject
{

    public string gameName = "Arkanoid";
    public Color [] bricksPalette;

    public Texture2D[] toolbarIcons;

    //  btw: https://docs.unity3d.com/ScriptReference/PlayerPrefs.html

    public List<ArkanoidConfigLevel> levels = new List<ArkanoidConfigLevel>();


    public GameObject brickPrefab;

    static public void createBricks(List<List<int>> levelData){
        int iline = 0;
        foreach (List<int> line in levelData) {
            int icell = 0;
            foreach (int cell in line) {
                Debug.Log("Line, cell: ["+iline.ToString()+","+ icell.ToString() +"]  " 
                //+ line.ToString() + " " 
                + cell.ToString());
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
}

[System.Serializable]
public class ArkanoidConfigLevel {

    public string name;  // Level name
    public TextAsset data;

    static public List<List<int>> parseLevelData(string contents) {
        List<List<int>> levelData = new List<List<int>>();
        string[] lines = contents.Split('\n');
        Debug.Log("LOADED: " + lines.Length + " lines");

        foreach (string line in lines)
        {
            string[] cells = line.Split(',');
            // Debug.Log(" cells in the line: " + cells.Length);
            if (cells.Length < 2)
            {
                continue; //  Empty line, skip
            }

            List<int> levelRowData = new List<int>();
            foreach (string cell in cells)
            {
                int brick_index = int.Parse(cell);
                Debug.Log("Brick: " + brick_index);
                levelRowData.Add(brick_index);
            }

            levelData.Add(levelRowData);
        }
        return levelData;
    }

    public List<List<int>> GetLevelData()
    {
        return parseLevelData(data.text);
    }
}
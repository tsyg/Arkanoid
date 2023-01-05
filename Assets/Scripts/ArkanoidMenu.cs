using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class ArkanoidMenu : MonoBehaviour
{

    public UnityEvent OnCoolHappend = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        OnCoolHappend.Invoke();
    }


    public void StartNewGame() {

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Loadlevel(int levelNumber) {
        Arkanoid.Action("Level:" + levelNumber);
    }


    public void OnGui() {
        // Is called twice in a gamecycle
        // See GUI,   GUILayout
    }

    // Gizmos - invisible objects - developers-only. Not visible in game    

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 0.1f);
    }

}

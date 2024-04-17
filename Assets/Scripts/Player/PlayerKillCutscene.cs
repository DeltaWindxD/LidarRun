using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKillCutscene : MonoBehaviour
{
    //Checks if player is colliding with the enemy and if so go to cutscene and activate all necessary objects and deactivate some other objects
    public GameObject Timeline;

    public GameObject Music;

    public GameObject Heartbeat;

    public GameObject GameUi;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Enemy")
        {
            GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = false;
            GameObject.Find("fredmonster").layer = 0;
            GameObject.Find("Cone").layer = 0;
            GameObject.Find("Cube").layer = 0;
            GameObject.Find("Mball").layer = 0;
            GameObject.Find("Mball.001").layer = 0;   
            GameObject.Find("Plane.001").layer = 0; 
            GameObject.Find("Body").layer = 0;
            GameUi.SetActive(false);
            Music.SetActive(false); 
            Timeline.SetActive(true);
            Heartbeat.SetActive(false);
        }
          
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKillCutscene : MonoBehaviour
{

    public GameObject Timeline;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Enemy")
        {
            GameObject.Find("PlayerCamera").GetComponent<PlayerController>().enabled = false;
            Timeline.SetActive(true);
        }
          
    }
}

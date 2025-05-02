using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Presets;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public bool Nappi = false;
    public GameObject player;
    private Vector3 ensimmäinen = new Vector3(0, 7, 0);
    private Vector3 kolmas = new Vector3(0, 7, -10);
    void LateUpdate()
    {
        if (Input.GetButton("V")){
            Nappi = !Nappi;
        }
        if (Nappi == false){
            transform.position = player.transform.position + kolmas;
        }
        else { 
            transform.position = player.transform.position + ensimmäinen;
        }
    }
}

using System;
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
    public Camera ensimm�inen;
    public Camera kolmas;
    private bool onkoKolmas = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)){
            Debug.Log("Nappi");
            KameraVaihto();
        }
    }
    void KameraVaihto(){
        if (onkoKolmas){
            Debug.Log("Ensimm�inen");
            ensimm�inen.gameObject.SetActive(true);
            kolmas.gameObject.SetActive(false);
        }else{
            Debug.Log("Kolmas");
            ensimm�inen.gameObject.SetActive(false);
            kolmas.gameObject.SetActive(true);
        }
    }
}

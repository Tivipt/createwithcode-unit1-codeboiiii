using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeuraaPelaajaa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -10);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

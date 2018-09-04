using UnityEngine;
using System.Collections;

public class pls : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    void Start ()
    {
        transform.position = new Vector3(1, 1, 1);
    }
    
    void LateUpdate ()
    {
        transform.position = transform.position + new Vector3(1, 1, 1);
    }
}

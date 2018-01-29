using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wrld;
using Wrld.Common.Maths;
using Wrld.Space;


public class Move_player : MonoBehaviour {
    public GameObject cam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        /*
        var ecefPos = Wrld.Api.Instance.CameraApi.

        if (Input.GetAxis("Vertical") > 0)
        {
            ecefPos += (cam.transform.forward) * 10;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            ecefPos -= (cam.transform.forward) * 10;
        }

        Wrld.Api.Instance.SetOriginPoint(LatLongAltitude.FromECEF(ecefPos));
        */
        
        if(Input.GetAxis("Vertical") > 0)
        {
            transform.position = transform.position + (cam.transform.forward) * 10;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.position = transform.position - (cam.transform.forward) * 10;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public Vector3 StartPosition = new Vector3(0.0f, 0.5f, 0.0f);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float time = UnityEngine.Time.time;
        float offset = Mathf.Sin(time * 2.0f);
        offset *= 2.0f;

        this.transform.localPosition = this.StartPosition + Vector3.up * offset;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereJumping : MonoBehaviour {
    public Vector3 movement = new Vector3(0.0f, 5.0f, 0.0f);

    // Update is called once per frame
    void Update () {
        transform.Translate(movement * Mathf.Sin(Time.fixedTime));
    }
}

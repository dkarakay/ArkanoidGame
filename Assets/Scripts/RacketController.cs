using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour {

    //Movement Speed
    public float speed = 150;


	void FixedUpdate () {

        float button = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * button * speed;
    }
}

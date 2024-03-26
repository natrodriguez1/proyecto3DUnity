using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCarMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float speed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
      if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
        transform.Rotate(new Vector3(0,-0.25f,0));
      }
      if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
        transform.Rotate(new Vector3(0,0.25f,0));
      }
    }
}

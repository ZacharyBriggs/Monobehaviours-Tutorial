using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform target;
    private Vector3 boom;
    public float Speed;
    private CharacterController controller;
	// Use this for initialization
	void Start ()
	{
	    controller = gameObject.GetComponent<CharacterController>();
        boom = this.transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 move_direction = new Vector3(0,0,0);
        transform.LookAt(target.position);
	    move_direction = transform.forward * Speed;
	    controller.Move(move_direction * Time.deltaTime);
    }
}

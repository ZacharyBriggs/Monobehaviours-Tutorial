using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour player;
    private Vector3 boom;
    public float Speed;
    private CharacterController controller;
	// Use this for initialization
	void Start ()
	{
	    player = GameObject.FindObjectOfType<PlayerMovementBehaviour>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 dirToPlayer;
	    dirToPlayer = player.transform.position - this.transform.position;
        dirToPlayer.Normalize();
	    transform.position += dirToPlayer * Speed * Time.deltaTime;
	}
}

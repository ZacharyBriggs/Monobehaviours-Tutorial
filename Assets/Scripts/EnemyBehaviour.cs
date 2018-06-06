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
	    dirToPlayer.x = player.transform.position.x - this.transform.position.x;
	    dirToPlayer.y = 0;
	    dirToPlayer.z = player.transform.position.z - this.transform.position.z;
        dirToPlayer.Normalize();
	    transform.position += dirToPlayer * Speed * Time.deltaTime;
	}
}

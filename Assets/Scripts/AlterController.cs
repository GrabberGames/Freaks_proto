using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AlterController : MonoBehaviour
{
    private NavMeshAgent alter;
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        alter = GetComponent<NavMeshAgent>();
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        gameController.ObjectMove(alter);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Hero_B")
        {
            Debug.Log("Hit");
            gameController.redAlters.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}

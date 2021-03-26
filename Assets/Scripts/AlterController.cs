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
        if (other.gameObject.name == "Hero_B" && gameObject.name == "Alter1")
        {
            Debug.Log("Hit: HeroB + AlterR");
            gameController.redAlters.Remove(gameObject);

            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Hero_R" && gameObject.name == "Alter2")
        {
            Debug.Log("Hit: HeroR + AlterB");
            gameController.blueAlters.Remove(gameObject);

            Destroy(gameObject);
        }
    }
}

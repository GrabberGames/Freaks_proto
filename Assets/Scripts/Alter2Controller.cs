using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alter2Controller : MonoBehaviour
{

    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        gameController.ObjectMove();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Hero_R")
        {
            Debug.Log("Hit");
            gameController.blueAlters.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}

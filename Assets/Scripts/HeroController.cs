using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class HeroController : MonoBehaviour
{
    private NavMeshAgent hero;
    private RaycastHit hit; // Hit Checker
    private string heroName;

    private bool isClicked;

    GameController gameController;

    // Start is called before the first frame update
    private void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

    }

    // Update is called once per frame
    private void Update()
    {
        gameController.ObjectMove();
    }
}

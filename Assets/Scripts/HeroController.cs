using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HeroController : MonoBehaviour
{
    private NavMeshAgent hero;
    private RaycastHit hit; // Hit Checker

    private bool isClicked;

    GameController gameController;

    // Start is called before the first frame update
    private void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        hero = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (gameController.FindPC() == "Hero")  // if Clicked PC name is Hero
        {
            isClicked = true;   // Clicked Check
        }
        else
        {
            isClicked = false;
        }

        if (Input.GetMouseButtonDown(1) && isClicked == true)    // Right Mouse Click && Hero Clicked
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    // Ray Set; Mouse Pointer Position

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                hero.SetDestination(hit.point); // Hero Move
            }
        } 
    }
}

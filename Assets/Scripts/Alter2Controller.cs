using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alter2Controller : MonoBehaviour
{
    private NavMeshAgent alter;
    private RaycastHit hit;    // Hit Checker

    private bool isClicked;

    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        alter = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.FindPC() == "Alter2")  // if Clicked PC name is Alter
        {
            isClicked = true;   // Clicked Check
        }
        else
        {
            isClicked = false;
        }

        if (Input.GetMouseButtonDown(1) && isClicked == true) // Right Mouse Click && Alter Clicked
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    // Ray Set; Mouse Pointer Position

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                alter.SetDestination(hit.point);    // Alter Move
            }
        }

    }
}

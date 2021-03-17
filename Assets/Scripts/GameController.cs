using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameController : MonoBehaviour
{
    private NavMeshAgent pc;
    private RaycastHit hit;    // Hit Checker
    private string hitColliderName;

    // Team Separation
    public GameObject[] blueAlters;
    public GameObject[] redAlters;

    // Start is called before the first frame update
    private void Start()
    {
        pc = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        FindPC();
    }


    // Find + return Cliked PC name
    public string FindPC()
    {
        if (Input.GetMouseButtonDown(0)) // Left Mouse Click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, Mathf.Infinity);   // Shot Ray

            hitColliderName = hit.collider.name;   
        }

        return hitColliderName;  // return Clicked PC Name
    }

}

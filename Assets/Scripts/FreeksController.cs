using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

enum Team
{
    Blue,
    Red
}

public class FreeksController : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameController gameController;

    private Team myTeam = Team.Blue;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(SearchCloseEnemyAlter().transform.position);
    }

    // Find nearest enemy Alter
    GameObject SearchCloseEnemyAlter()
    {
        GameObject[] enemyAlters;
        if (myTeam == Team.Blue)
        {
            enemyAlters = gameController.redAlters;
        }
        else
        {
            enemyAlters = gameController.blueAlters;
        }


        int closeAlterNum = 0;
        float min = (transform.position - enemyAlters[0].transform.position).sqrMagnitude;

        for(int i = 1; i < enemyAlters.Length; i++)
        {
            float distance = (transform.position - enemyAlters[i].transform.position).sqrMagnitude;
            if (min > distance)
            {
                min = distance;
                closeAlterNum = i;
            }
        }

        return enemyAlters[closeAlterNum];
    }
}

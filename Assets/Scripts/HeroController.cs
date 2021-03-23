using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class HeroController : MonoBehaviour
{
    private NavMeshAgent hero;
    private RaycastHit hit; // Hit Checker
    bool attackDown;   

    Animator anim;

    GameController gameController;

    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        hero = GetComponent<NavMeshAgent>();
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

    }

    // Update is called once per frame
    private void Update()
    {
        attackDown = Input.GetButton("Attack");     // Attack 버튼을 프로젝트 설정에서 space로 바꿔줬습니다!
        gameController.ObjectMove(hero);
        anim.SetFloat("Move", hero.velocity.magnitude); // 움직이는동안 움직이는 모션
        anim.SetBool("isAttack", attackDown);   // Attack(space) 버튼 누르면 공격 모션
    }
}

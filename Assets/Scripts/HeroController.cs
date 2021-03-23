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
        attackDown = Input.GetButton("Attack");     // Attack ��ư�� ������Ʈ �������� space�� �ٲ�����ϴ�!
        gameController.ObjectMove(hero);
        anim.SetFloat("Move", hero.velocity.magnitude); // �����̴µ��� �����̴� ���
        anim.SetBool("isAttack", attackDown);   // Attack(space) ��ư ������ ���� ���
    }
}

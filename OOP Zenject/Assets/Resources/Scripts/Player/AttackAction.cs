using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction : PlayerAction
{
    private  IEnemyService IenemyService;
    private readonly float attackRange = 50;
    private  EnemyService enemyService;


    [SerializeField] private AudioClip playerSwordSound;
    private AudioSource source;
   
    
    public override void Execute(GameObject playerObject)
    {
        source = playerObject.GetComponent<AudioSource>();
        playerSwordSound = Resources.Load<AudioClip>("Audio/fb5b527adcfa08b");
        Debug.Log(playerSwordSound);
        enemyService = GameObject.Find("Enemy").GetComponent<EnemyService>();   
        
        if (EnemyService.nearestEnemy != null)
        {
           
            Enemy.instance.TakeDamage(10);
            Debug.Log("NearestEnemy != null");
           
            source.PlayOneShot(playerSwordSound);
            //SoundManager.PlaySwordSound();

            Debug.Log("����� �������� �����");
        }
    }
   
}










//public override void Execute(GameObject playerObject)
//{
//    // ������� ���������� ����� � ������� 5 ������ �� ������
//    Collider[] colliders = Physics.OverlapSphere(playerObject.transform.position, 5f, LayerMask.GetMask("Enemies"));
//    if (colliders.Length > 0)
//    {
//        // ������� ���������� �����
//        Enemy enemy = colliders[0].GetComponent<Enemy>();
//        if (enemy != null)
//        {
//            enemy.TakeDamage(10);
//            Debug.Log("����� �������� �����");
//        }
//    }
//} 
//public AttackAction(IEnemyService enemyService, float attackRange)
//{
//    this.IenemyService = enemyService;
//    this.attackRange = attackRange;
//}
using System;
using System.Collections.Generic;
using System.Text;
using _001_Scripts.Entity;
using _001_Scripts.ETC;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int goal = 50;
    [SerializeField] bool isGameEnd = false;
    [SerializeField] GameObject entityPrefab;
    [SerializeField] private int turn = 0;

    [SerializeField] private Transform spawnPoint;

    private EntityBase enemy;
    private EntityBase player;

    private void Start()
    {
        turn = 0;

        player = GetComponent<Player>();
        GameObject obj = Instantiate(entityPrefab, spawnPoint.position, spawnPoint.rotation);
        enemy = obj.GetComponent<EntityBase>();
        
        Debug.Log($"{enemy.hp} {enemy.def}");
        Debug.Log($"{entityPrefab.GetType().Name} is appear! what should I do?");
    }

    public void Attack()
    {
        Debug.Log($"{BuildText(player.Attack(enemy))}");
        
        if (enemy.isDead())
            Debug.Log("Game end");
        
        turn++;
    }

    public void Regenerate()
    {
        Debug.Log($"{BuildText(player.Regenerate(player))}");
        turn++;
    }


    private string BuildText(interactionResult rst)
    {
        StringBuilder strBuilder = new();

        strBuilder.Append($"행동 타입: {rst.actingType}\n");
        strBuilder.Append($"행동 값: {rst.value}\n");
        strBuilder.Append($"행동 대상: {rst.target}\n");
        strBuilder.Append($"남은 hp: {rst.target.hp}");
        
        return strBuilder.ToString();
    }
}
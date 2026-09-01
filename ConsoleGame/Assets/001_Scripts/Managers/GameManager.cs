using System.Text;
using _001_Scripts.Entity;
using _001_Scripts.ETC;
using UnityEngine;
using static _001_Scripts.Utils.MathUtil;

public class GameManager : MonoBehaviour
{
    [SerializeField] int goal = 50;
    [SerializeField] bool isGameEnd = false;
    [SerializeField] GameObject entityPrefab;
    [SerializeField] private int turn = 0;

    [SerializeField] private Transform spawnPoint;

    [SerializeField] private EntityBase player;
    private EntityBase enemy;

    private void Start()
    {
        turn = 0;

        player = GetComponent<Player>();
        GameObject obj = Instantiate(entityPrefab, spawnPoint.position, spawnPoint.rotation);
        enemy = obj.GetComponent<EntityBase>();
        
        Debug.Log($"{enemy.hp} {enemy.def}");
        Debug.Log($"{entityPrefab.GetType().Name} is appeared! what should I do?");
    }

    private void NextTurn()
    {
        turn++;

        
        if (turn % 2 == 1) // 홀수 감지용
        {
            Debug.Log(BuildText(enemy.Attack(player)));

            if (enemy.hp < 10 && RandomInt() < 50)
            {
                Debug.Log(BuildText(enemy.Regenerate(player)));
                NextTurn();
            }
            else
            {
                Debug.Log(BuildText(enemy.Attack(player)));
                NextTurn();
            }

            if (enemy.isDead())
                Debug.Log("enemy is dead");
            else if (player.isDead())
                Debug.Log("player is dead");
        }
    }

    public void Attack()
    {
        Debug.Log($"{BuildText(player.Attack(enemy))}");
        NextTurn();
    }

    public void Regenerate()
    {
        Debug.Log($"{BuildText(player.Regenerate(player))}");
        NextTurn();
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
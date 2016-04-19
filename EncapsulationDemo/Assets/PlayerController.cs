using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    int maxHp = 100;

    [SerializeField]
    int hp;

    // Use this for initialization
    void Start()
    {
        hp = maxHp;
    }


    public void Damage(int amount)
    {
        hp = Mathf.Max(0, hp - amount);
    }

    public void Heal(int amount)
    {
        hp = Mathf.Min(maxHp, hp + amount);
    }

    public int GetHp()
    {
        return hp;
    }

}

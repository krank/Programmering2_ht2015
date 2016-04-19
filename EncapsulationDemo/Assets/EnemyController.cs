using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

    int weaponDamage = 20;

    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.tag == "Player")
        {

            PlayerController pc = coll.gameObject.GetComponent<PlayerController>();

            pc.Damage(weaponDamage);

        }

    }

    
}

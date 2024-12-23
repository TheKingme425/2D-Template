using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 2;
    public Health playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Player")
      {
          if (playerHealth == null) 
          {
            playerHealth = collision.gameObject.GetComponent<Health>();
          }
          playerHealth.TakeDamage(2);
      }
    }   
}

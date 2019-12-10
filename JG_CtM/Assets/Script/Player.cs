using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    

    float rotateY;
    public Rigidbody rb;
    public event Action attack;
    private bool attacking;
    float attackDuration = 1f;
    
    public float speed;
    public float roatateSpeed;
    public GameObject HitBox;
    public Vector3 target; 
    void Start()
    {
        
    }
    
    void Update()
    {
       

        if (!attacking)
        {

        }
        if (!attacking && Input.GetKey(KeyCode.Space))
        {
            
            StartCoroutine(Attacker());
            print("Is attacking"); 
            
;
        }

        transform.position += transform.forward * speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, rotateY, 0);
    }

    private IEnumerator Attacker()
    {
        attack?.Invoke();

        attacking = true;

        yield return new WaitForSeconds(attackDuration);

        attacking = false;
    }

    public void Stopattack()
    {
        
    }
}

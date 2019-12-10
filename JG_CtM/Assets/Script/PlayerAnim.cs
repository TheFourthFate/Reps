using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public Animator anim;
    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    

    }
    
    private void Player_Attack()
    {
        anim.SetTrigger("Attack");
    }

    void Update()
    {
        anim.SetFloat("Speed", player.speed);
    }
}

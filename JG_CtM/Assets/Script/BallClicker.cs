using UnityEngine;
using UnityEngine.AI; 

public class BallClicker : MonoBehaviour
{
   
    public Vector3 target;
    

    private void Update()
    {

        var agent = GetComponent<NavMeshAgent>();
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                target = hit.point;
                
                if (hit.collider.gameObject == gameObject)
                {
                    agent.SetDestination(target);
                    //agent.SetDestination(transform.position);
                    //GetComponent<Player>().Stopattack(); 
                }
            }
        }
        
    }

}


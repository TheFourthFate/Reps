using UnityEngine;
using UnityEngine.AI; 

public class BallRoller : MonoBehaviour
{
    public float mspeed = 4f;
    public Vector3 target;

    public GameObject clickpart;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var agent = GetComponent<NavMeshAgent>();
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                target = hit.point;
                agent.SetDestination(target);
                GetComponent<Player>().Stopattack();
                Instantiate(clickpart, target, Quaternion.identity);
                
            }
        }                
    }
}

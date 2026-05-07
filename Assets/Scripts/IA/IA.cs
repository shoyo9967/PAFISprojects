using UnityEngine;
using UnityEngine.AI;

public class IA : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;

    public Transform[] destinations;

    private int i = 0;

    [Header("------------FollowPlayer?------------")]
    public bool followPlayer;   

    private GameObject player;

    private float distanceToPlayer;
    public float distanceToFollowPlayer = 10f;
    public float distanceToFollowPath = 2;

    /*
    para destinos de uno en uno:

    public GameObject destination1;
    public GameObject destination2;
    */

    void Start()
    {
      
        navMeshAgent.destination = destinations[0].transform.position;

        player = FindAnyObjectByType<PlayerMovement>().gameObject;
        
    }
    

    void Update()
    {
        // para destinos de uno en uno
        //float distance = Vector3.Distance(transform.position, destination1.transform.position);

       // if (distance < 2)
        //{
            //navMeshAgent.destination = destination2.transform.position;
        //}  

        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer <= distanceToFollowPlayer && followPlayer)
        {
            FollowPlayer();
        }
        else
        {
            EnemyPath();
        }
        
    

    }

    
    public void EnemyPath()
    {
        navMeshAgent.destination = destinations[i].transform.position;

        if (Vector3.Distance(transform.position, destinations[i].position) <= distanceToFollowPath)
         {
            if (destinations[i] != destinations[destinations.Length - 1])
            {
                i++;    
            } 
         
            else
            {
                i = 0;
            }
         }
    }
    

    public void FollowPlayer()
    {
        navMeshAgent.destination = player.transform.position;
    }

}


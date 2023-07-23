using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    protected NavMeshAgent mesh;
    public GameObject player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = transform.localScale;

        mesh.SetDestination(player.transform.position);

        if(player.transform.position.x > transform.position.x)
        {
            // set animatior horisontail + or - idk which
        }
        if (player.transform.position.x < transform.position.x)
        {
            // set animatior horisontail + or - idk which
        }
        if (player.transform.position.y > transform.position.y)
        {
            // set animatior vertical + or - idk which
        }
        if (player.transform.position.y < transform.position.y)
        {
            // set animatior vertical + or - idk which
        }

        transform.localScale = scale;
    }
}

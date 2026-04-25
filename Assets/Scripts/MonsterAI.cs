using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    private DirectionalVisual directionalVisual;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        directionalVisual = GetComponent<DirectionalVisual>();

        // PENTING: Untuk project lo, pastiin ini diset begini
        agent.updateRotation = false;

        // Coba comment baris di bawah kalau monster masih ga mau gerak
        // agent.updateUpAxis = true; 
    }

    void Update()
    {
        if (target == null || agent == null) return;

        // Cek apakah agent sudah menempel di NavMesh
        if (agent.isOnNavMesh)
        {
            agent.SetDestination(target.position);
        }

        // Update visual berdasarkan arah jalan
        if (directionalVisual != null && agent.velocity.magnitude > 0.1f)
        {
            directionalVisual.UpdateVisual(agent.velocity.normalized);
        }
    }
}
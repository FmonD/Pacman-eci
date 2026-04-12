using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public float moveSpeed = 4f;
    public Transform target;

    private CharacterController controller;
    private DirectionalVisual directionalVisual;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        directionalVisual = GetComponent<DirectionalVisual>();
    }

    void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position);
        direction.y = 0f;
        direction = direction.normalized;

        controller.Move(direction * moveSpeed * Time.deltaTime);

        if (directionalVisual != null)
        {
            directionalVisual.UpdateVisual(direction);
        }
    }
}

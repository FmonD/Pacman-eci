using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6f;

    private CharacterController controller;
    private Vector3 movement;
    private DirectionalVisual directionalVisual;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        directionalVisual = GetComponent<DirectionalVisual>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        movement = new Vector3(moveZ, 0f, -moveX).normalized;

        if (movement != Vector3.zero)
        {
            controller.Move(movement * moveSpeed * Time.deltaTime);

            if (directionalVisual != null)
            {
                directionalVisual.UpdateVisual(movement);
            }
        }
    }
}

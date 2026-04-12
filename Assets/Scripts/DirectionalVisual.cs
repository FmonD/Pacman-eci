using UnityEngine;

public class DirectionalVisual : MonoBehaviour
{
    public GameObject frontModel;
    public GameObject backModel;
    public GameObject leftModel;
    public GameObject rightModel;

    void Start()
    {
        SetActiveModel(frontModel);
    }

    public void UpdateVisual(Vector3 direction)
    {
        // Karena X dan Z sudah ketukar di movement,
        // kita baca kebalik di sini

        if (direction.z > 0)
            SetActiveModel(rightModel);
        else if (direction.z < 0)
            SetActiveModel(leftModel);
        else if (direction.x > 0)
            SetActiveModel(backModel);
        else if (direction.x < 0)
            SetActiveModel(frontModel);
    }

    void SetActiveModel(GameObject activeModel)
    {
        frontModel.SetActive(false);
        backModel.SetActive(false);
        leftModel.SetActive(false);
        rightModel.SetActive(false);

        activeModel.SetActive(true);
    }
}

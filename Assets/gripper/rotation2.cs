using UnityEngine;

public class rotation2 : MonoBehaviour
{
    public test T;

    void Update()
    {
        float value;
        value = -T.fuss;

        Debug.Log(value);

        this.transform.rotation = Quaternion.AngleAxis(value, Vector3.up);
    }
}
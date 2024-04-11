using UnityEngine;

public class objective: MonoBehaviour
{
    public static Vector3 targetPos;

    void Start()
    {
        targetPos = GetComponent<Transform>().position;
    }
}
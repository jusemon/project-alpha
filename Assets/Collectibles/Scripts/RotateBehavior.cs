using UnityEngine;

public class RotateBehavior : MonoBehaviour
{
    public enum DirectionEnum
    {
        Right,
        Left,
        Up,
        Down
    }

    [SerializeField]
    public float Speed = 1f;

    [SerializeField]
    public DirectionEnum Direction = DirectionEnum.Right;

    // Update is called once per frame
    void Update()
    {
        var current = gameObject.transform.rotation;
        if (Direction == DirectionEnum.Left || Direction == DirectionEnum.Right)
        {
            gameObject.transform.rotation = new Quaternion(Speed * Time.deltaTime * (Direction == DirectionEnum.Left ? -1 : 1), current.y, current.z, current.w);
        }
        else
        {
            gameObject.transform.rotation = new Quaternion(current.x, Speed * Time.deltaTime * (Direction == DirectionEnum.Down ? -1 : 1), current.z, current.w);
        }
    }
}

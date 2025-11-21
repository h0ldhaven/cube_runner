using UnityEngine;

[CreateAssetMenu(menuName = "Runner/PlayerData")]
public class PlayerData : MonoBehaviour
{
    [SerializeField] public float forwardSpeed = 10f;
    [SerializeField] public float laneDistance = 2f;
    [SerializeField] public float lateralSmooth = 10f;
    [SerializeField] public int startLane = 1;
}

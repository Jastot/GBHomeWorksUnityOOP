using UnityEngine;

namespace MazeBall
{
    [CreateAssetMenu(fileName = "PlayerSettings", menuName = "Data/Player")]
    public sealed class PlayerData: ScriptableObject, IPlayerStats
    {
        [SerializeField, Range(0, 1000)] private float _speed;
        [SerializeField, Range(0, 100)] private int _heath;
        [SerializeField, Range(0, 100)] private int _maxScore;

        public Mesh mesh;
        public Material material;
        public float Speed => _speed;
        public int Heath => _heath;
        public int MaxPoints => _maxScore;
     
    }
}
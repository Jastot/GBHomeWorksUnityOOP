using System;
using UnityEngine;

namespace MazeBall
{
    [Serializable]
    public class InteractiveStructe
    {
        public GameObject Enemy;
        public InterectiveObjectType Type;
        //public InteractiveProvider EnemyPrefab;
        public PlayerModel Target;
        public Vector3 _position;
        public Mesh Mesh;
        public Material Material;

        public int Health;
        public int Speed;
    }
}
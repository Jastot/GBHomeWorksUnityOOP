using System;
using UnityEngine;

namespace MazeBall
{
    [Serializable]
    public struct PlayerStruct
    {
        public GameObject Player;
        public Vector3 StartPosition;
        public Mesh Mesh;
        public Material Material;

        public int Health;
        public float Speed;
        public int CurrentPoints;
        public int MaxPoint;
    }
}
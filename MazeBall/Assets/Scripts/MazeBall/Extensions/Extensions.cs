using TMPro;
using UnityEditor.UIElements;
using UnityEngine;

namespace MazeBall
{
    public static partial class Extensions
    {
        public static GameObject SetName(this GameObject gameObject, string name)
        {
            gameObject.name = name;
            return gameObject;
        }

        public static GameObject AddRigidbody(this GameObject gameObject, float mass)
        {
            var component = gameObject.GetOrAddComponent<Rigidbody>();
            component.mass = mass;
            return gameObject;
        }

        public static GameObject AddSphereCollider(this GameObject gameObject)
        {
            gameObject.GetOrAddComponent<SphereCollider>();
            return gameObject;
        }

        public static GameObject AddMeshRenderer(this GameObject gameObject, Material material)
        {
            var component = gameObject.GetOrAddComponent<MeshRenderer>();
            component.materials[0] = material;
            return gameObject;
        }
        public static GameObject AddMeshFilter(this GameObject gameObject, Mesh mesh)
        {
            var component = gameObject.GetOrAddComponent<MeshFilter>();
            component.mesh = mesh;
            return gameObject;
        }

        public static GameObject AddTag(this GameObject gameObject, string tag)
        {
            gameObject.tag = tag;
            return gameObject;
        }
        
        public static GameObject AddScript(this GameObject gameObject, string scriptName)
        {
            gameObject.AddScript(scriptName);
            return gameObject;
        }
        private static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var result = gameObject.GetComponent<T>();
            if (!result)
            {
                result = gameObject.AddComponent<T>();
            }

            return result;
        }
        
        
    }
}
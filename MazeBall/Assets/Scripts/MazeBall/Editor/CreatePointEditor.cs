﻿#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace MazeBall.Editor
{
    [CustomEditor(typeof(CreateNewPoint))]
    public class CreatePointEditor : UnityEditor.Editor
    {
        private CreateNewPoint _testTarget;

        private void OnEnable()
        {
            _testTarget = (CreateNewPoint)target;
        }


        private void OnSceneGUI()
        {
            if (Event.current.button == 0 && Event.current.type == EventType.MouseDown)
            {
                Ray ray = Camera.current.ScreenPointToRay(new Vector3(Event.current.mousePosition.x,
                    SceneView.currentDrawingSceneView.camera.pixelHeight - Event.current.mousePosition.y));

                if (Physics.Raycast(ray, out var hit))
                {
                    _testTarget.InstantiateObj(hit.point);
                    SetObjectDirty(_testTarget.gameObject);
                }
            }

            Selection.activeGameObject = _testTarget.gameObject;

        }

        public void SetObjectDirty(GameObject obj)
        {
            if (!Application.isPlaying)
            {
                EditorUtility.SetDirty(obj);
                EditorSceneManager.MarkSceneDirty(obj.scene);
            }
        }
    }
#endif
}
using UnityEngine;
using UnityEditor;

namespace Kino
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Bloom))]
    public class Bloomditor : Editor
    {
        SerializedProperty _radius;
        SerializedProperty _threshold;
        SerializedProperty _intensity;
        SerializedProperty _temporalFiltering;

        void OnEnable()
        {
            _radius = serializedObject.FindProperty("_radius");
            _threshold = serializedObject.FindProperty("_threshold");
            _intensity = serializedObject.FindProperty("_intensity");
            _temporalFiltering = serializedObject.FindProperty("_temporalFiltering");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_radius);
            EditorGUILayout.PropertyField(_threshold);
            EditorGUILayout.PropertyField(_intensity);
            EditorGUILayout.PropertyField(_temporalFiltering);

            serializedObject.ApplyModifiedProperties();
        }
    }
}

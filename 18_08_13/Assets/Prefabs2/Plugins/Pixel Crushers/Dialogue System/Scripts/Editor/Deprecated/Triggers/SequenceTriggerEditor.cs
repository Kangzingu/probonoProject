// Copyright � Pixel Crushers. All rights reserved.

using UnityEngine;
using UnityEditor;
using System;

namespace PixelCrushers.DialogueSystem
{

    [CustomEditor(typeof(SequenceTrigger), true)]
    public class SequenceTriggerEditor : Editor
    {

        private Rect sequenceRect;

        public void OnEnable()
        {
            EditorTools.SetInitialDatabaseIfNull();
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorWindowTools.DrawDeprecatedTriggerHelpBox();
            var trigger = target as SequenceTrigger;
            if (trigger == null) return;
            var triggerProperty = serializedObject.FindProperty("trigger");
            EditorGUILayout.PropertyField(triggerProperty);
            if (DialogueTriggerEventDrawer.IsEnableOrStartEnumIndex(triggerProperty.enumValueIndex))
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("waitOneFrameOnStartOrEnable"), new GUIContent("Wait 1 Frame", "Tick to wait one frame to allow other components to finish their OnStart/OnEnable"));
            }
            serializedObject.ApplyModifiedProperties();
            EditorGUI.BeginChangeCheck();
            var newSequence = SequenceEditorTools.DrawLayout(new GUIContent("Sequence"), trigger.sequence, ref sequenceRect);
            var changed = EditorGUI.EndChangeCheck();
            serializedObject.Update();
            if (changed) serializedObject.FindProperty("sequence").stringValue = newSequence;

            EditorGUILayout.PropertyField(serializedObject.FindProperty("speaker"), true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("listener"), true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("once"), true);
            EditorTools.DrawReferenceDatabase();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("condition"), true);
            serializedObject.ApplyModifiedProperties();
        }

    }

}

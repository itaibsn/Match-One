using System;
using Entitas;
using Entitas.Unity.VisualDebugging;
using UnityEditor;

public class IntVector2TypeDrawer : ITypeDrawer {

    public bool HandlesType(Type type) {
        return type == typeof(IntVector2);
    }

    public object DrawAndGetNewValue(Type memberType, string memberName, object value, IComponent component) {
        var vector = (IntVector2)value;
        vector.x = EditorGUILayout.IntField("x", vector.x);
        vector.y = EditorGUILayout.IntField("y", vector.y);
        return vector;
    }
}

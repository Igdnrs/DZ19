using UnityEngine;

public static class CalcHand
{
    public static Transform FindDeepChild(Transform parent, string name)
    {
        foreach (Transform child in parent)
        {
            if(child.name == name) return child;
            Transform result = FindDeepChild(child, name);
            if(result != null) return result;
        }
        return null;
    }
}

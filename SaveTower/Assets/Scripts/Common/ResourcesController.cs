using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ResourcesController : MonoBehaviour
{
    public static void AppendResourceAmount(ResourceType type, float amount)
    {
        if (!PlayerPrefs.HasKey(type.ToString())) PlayerPrefs.SetFloat(type.ToString(), 0);
        if (GetResourceAmount(type) + amount < 0) return;
        PlayerPrefs.SetFloat(type.ToString(), GetResourceAmount(type) + amount);
    }

    public static float GetResourceAmount(ResourceType type)
    {
        return PlayerPrefs.GetFloat(type.ToString());
    }
}

public enum ResourceType
{
    None = 0,
    Money = 1,
}

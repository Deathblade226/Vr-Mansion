using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropArea : MonoBehaviour
{
    public void GameObjectEntered(GameObject go)
    {
        Debug.Log($"GameObject {go.name} entered Drop Area");
    }
}

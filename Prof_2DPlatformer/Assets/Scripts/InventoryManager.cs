﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject invIconPrefab;

    private void Start()
    {
     
    }

    public void toggleShow() {
        float ys = transform.localScale.y;
        transform.localScale = new Vector3(1, -1 * ys, 1);
    }

    public void buildIcon(GameObject pickedUp)
    {
        Transform box = findEmptyBox();
        if (box == null)
        {
            print("No room in inventory");
            return;
        }
        GameObject g = Instantiate(invIconPrefab);
        g.GetComponent<InventoryManager>().sprite = pickedUp.GetComponent<SpriteRenderer>().sprite;
        g.transform.SetParent(box, false);
    }

    Transform findEmptyBox()
    {
        foreach (InvBox b in GetComponentsInChildren<InvBox>())
        {
            if (b.transform.childCount == 0)
                return b.transform;
        }
        return null;
    }

}

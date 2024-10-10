using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningController : PickUpController
{
    public int speedInc;

    public override void invClick(GameObject invIconGO) {
        base.invClick(invIconGO);

        PlayerController p = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        p.speed += speedInc;
    }
}

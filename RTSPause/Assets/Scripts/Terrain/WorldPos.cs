﻿using UnityEngine;
using System.Collections;

public struct WorldPos {
    public int x;
    public int y;
    public int z;

    public WorldPos(int x, int y, int z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public Vector3 ToVector() {
        return new Vector3(x, y, z);
    }
}
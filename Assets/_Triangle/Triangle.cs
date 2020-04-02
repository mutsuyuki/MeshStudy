using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class Triangle : MonoBehaviour {
    void Start() {
        var mesh = new Mesh();

        // 頂点
        var vertices = new List<Vector3> {
            new Vector3(0.0f, 0.0f, 0.0001f),
            new Vector3(0.5f, 0.0f, 0.0001f),
            new Vector3(0.0f, 0.5f, 0.0001f),
            new Vector3(0.5f, 0.5f, 0.0001f),
        };
        mesh.SetVertices(vertices);

        // カラー
        var colors = new List<Color> {
            Color.red,
            Color.green,
            Color.blue,
            Color.white,
        };
        mesh.SetColors(colors);

        // UV
        var uvs = new List<Vector2> {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1),
        };
        mesh.SetUVs(0, uvs);

        // インデックス
        var triangles = new List<int> {
            0, 1, 2,
            2, 1, 0,
            2, 1, 3,
            3, 1, 2
        };
        mesh.SetTriangles(triangles, 0);

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
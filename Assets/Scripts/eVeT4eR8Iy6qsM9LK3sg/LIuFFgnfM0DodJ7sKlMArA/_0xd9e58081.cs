using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xd9e58081 : MonoBehaviour
{
    private Vector3 _0xdc8698b8 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x6c9fe234;
        Matrix4x4 _0x53486b08 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x6a858e79.orthographic)
        {
            float _0x36da4fc8 = this._0x6a858e79.farClipPlane - this._0x6a858e79.nearClipPlane;
            float _0xc29711ac = (this._0x6a858e79.farClipPlane + this._0x6a858e79.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xc29711ac), new Vector3(this._0x6a858e79.orthographicSize * 2 * this._0x6a858e79.aspect, this._0x6a858e79.orthographicSize * 2, _0x36da4fc8));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x6a858e79.fieldOfView, this._0x6a858e79.farClipPlane, this._0x6a858e79.nearClipPlane, this._0x6a858e79.aspect);
        }

        Gizmos.matrix = _0x53486b08;
    }

    private void _0x1dbbcc98()
    {
        float _0xbb91591c, _0x2fbcc77e, _0xabfb269d, _0x3101af51;
        if (this._0x933d0896 == _0x3e924141.Landscape)
            this._0x6a858e79.orthographicSize = 1f / this._0x6a858e79.aspect * this._0x5408cedf / 2f;
        else
            this._0x6a858e79.orthographicSize = this._0x5408cedf / 2f;
        this._0x7e03b7a3 = 2f * this._0x6a858e79.orthographicSize;
        this._0x1437e783 = this._0x7e03b7a3 * this._0x6a858e79.aspect;
        float _0x6f82f5ce = this._0x6a858e79.transform.position.x;
        float _0xa7fbf8a3 = this._0x6a858e79.transform.position.y;
        _0xbb91591c = _0x6f82f5ce - this._0x1437e783 / 2;
        _0x2fbcc77e = _0x6f82f5ce + this._0x1437e783 / 2;
        _0xabfb269d = _0xa7fbf8a3 + this._0x7e03b7a3 / 2;
        _0x3101af51 = _0xa7fbf8a3 - this._0x7e03b7a3 / 2;
        this._0x3bf0a018 = new Vector3(_0xbb91591c, _0x3101af51, 0);
        this._0xf396087e = new Vector3(_0x6f82f5ce, _0x3101af51, 0);
        this._0x910434d1 = new Vector3(_0x2fbcc77e, _0x3101af51, 0);
        this._0xbff3c2f6 = new Vector3(_0xbb91591c, _0xa7fbf8a3, 0);
        this._0x7389ca2a = new Vector3(_0x6f82f5ce, _0xa7fbf8a3, 0);
        this._0xe5137cc9 = new Vector3(_0x2fbcc77e, _0xa7fbf8a3, 0);
        this._0x0e330f99 = new Vector3(_0xbb91591c, _0xabfb269d, 0);
        this._0x78f5b856 = new Vector3(_0x6f82f5ce, _0xabfb269d, 0);
        this._0xdc8698b8 = new Vector3(_0x2fbcc77e, _0xabfb269d, 0);
    }

    private float _0x5408cedf = 1;
    private Vector3 _0xe5137cc9 { get; set; }
    private Vector3 _0x910434d1 { get; set; }

    private new Camera _0x6a858e79;
    private Vector3 _0xbff3c2f6 { get; set; }
    //public bool executeInUpdate;
    private float _0x1437e783 { get; set; }

    private void Awake()
    {
        this._0x6a858e79 = this.GetComponent<Camera>();
        _0x65114d30 = this;
        this._0x1dbbcc98();
    }

    private Vector3 _0x3bf0a018 { get; set; }
    private float _0x7e03b7a3 { get; set; }

    private _0x3e924141 _0x933d0896 = _0x3e924141.Portrait;
    private Vector3 _0x78f5b856 { get; set; }

    public enum _0x3e924141
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xf396087e { get; set; }

    private static _0xd9e58081 _0x65114d30;
    private Color _0x6c9fe234 = Color.white;
    private Vector3 _0x7389ca2a { get; set; }
    private Vector3 _0x0e330f99 { get; set; }
}
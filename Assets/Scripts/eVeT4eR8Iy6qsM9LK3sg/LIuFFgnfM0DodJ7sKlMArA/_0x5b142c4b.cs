using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x5b142c4b : MonoBehaviour
{
    private static Rect _0xe206b14a = Rect.zero;
    private Vector2 _0x9784762b;
    private static void SafeAreaChanged()
    {
        _0xe206b14a = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private void _0x95c5757e()
    {
        if (this._0x1f8f9427 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x19900dcd = Screen.safeArea;
        Vector2 _0xc8e228bc = _0x19900dcd.position;
        Vector2 _0x6e73b8a6 = _0x19900dcd.position + _0x19900dcd.size;
        _0xc8e228bc.x /= screenWidth;
        _0xc8e228bc.y /= screenHeight;
        _0x6e73b8a6.x /= screenWidth;
        _0x6e73b8a6.y /= screenHeight;
        this._0x1f8f9427.anchorMin = _0xc8e228bc;
        this._0x1f8f9427.anchorMax = _0x6e73b8a6;
        this._0x1f8f9427.offsetMin = Vector2.zero;
        this._0x1f8f9427.offsetMax = Vector2.zero;
        if (this._0x55c01d0e == null)
            return;
        Vector2 _0xb13befe5 = _0x6e73b8a6 - _0xc8e228bc;
        float _0xece76062 = 2f - _0xb13befe5.x;
        float _0xb23a401c = 2f - _0xb13befe5.y;
        this._0x55c01d0e.referenceResolution = this._0x9784762b * new Vector2(_0xece76062, _0xb23a401c);
    }

    private static bool _0x0f4e2949;
    private void OnDestroy()
    {
        if (_0xf8a0a5aa != null && _0xf8a0a5aa.Contains(this))
            _0xf8a0a5aa.Remove(this);
    }

    private CanvasScaler _0x55c01d0e;
    private static ScreenOrientation _0x60622d8e = ScreenOrientation.LandscapeLeft;
    private void Start()
    {
    }

    private RectTransform _0x37848d92;
    private static Vector2 _0x0b737e57 = Vector2.zero;
    private static void ResolutionChanged()
    {
        _0x0b737e57.x = Screen.width;
        _0x0b737e57.y = Screen.height;
        _0xe206b14a = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x761a22c9.Invoke();
    }

    private void Awake()
    {
        if (!_0xf8a0a5aa.Contains(this))
            _0xf8a0a5aa.Add(this);
        this._0x5cf9ddfd = this.GetComponent<Canvas>();
        this._0x55c01d0e = this.GetComponent<CanvasScaler>();
        if (this._0x55c01d0e != null)
            this._0x9784762b = this._0x55c01d0e.referenceResolution;
        this._0x37848d92 = this.GetComponent<RectTransform>();
        this._0x1f8f9427 = this.transform.Find(_0xc03d85fc._0xb11ff9ca(new byte[8] { 126, 76, 75, 72, 108, 95, 72, 76 }, 45)) as RectTransform;
        if (!_0x0f4e2949)
        {
            _0x60622d8e = Screen.orientation;
            _0x0b737e57.x = Screen.width;
            _0x0b737e57.y = Screen.height;
            _0xe206b14a = Screen.safeArea;
            _0x0f4e2949 = true;
        }

        this._0x95c5757e();
    }

    private RectTransform _0x1f8f9427;
    private static readonly List<_0x5b142c4b> _0xf8a0a5aa = new();
    private static void ApplySafeAreaToAll()
    {
        for (int _0xf6330883 = 0; _0xf6330883 < _0xf8a0a5aa.Count; _0xf6330883++)
            _0xf8a0a5aa[_0xf6330883]._0x95c5757e();
    }

    private static UnityEvent _0x761a22c9 = new();
    private void Update()
    {
        if (_0xf8a0a5aa.Count == 0 || _0xf8a0a5aa[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x60622d8e)
            OrientationChanged();
        if (Screen.safeArea != _0xe206b14a)
            SafeAreaChanged();
        if (Screen.width != _0x0b737e57.x || Screen.height != _0x0b737e57.y)
            ResolutionChanged();
    }

    private Canvas _0x5cf9ddfd;
    private static void OrientationChanged()
    {
        _0x60622d8e = Screen.orientation;
        _0x0b737e57.x = Screen.width;
        _0x0b737e57.y = Screen.height;
        _0xe206b14a = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x761a22c9.Invoke();
    }
}

internal static class _0xc03d85fc
{
    internal static string _0xb11ff9ca(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
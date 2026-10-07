using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x07ab780f : MonoBehaviour
{
    private RectTransform _0xf697fc64;
    private Canvas _0x2fd667e2;
    private void OnDestroy()
    {
        if (_0x704ea900 != null && _0x704ea900.Contains(this))
            _0x704ea900.Remove(this);
    }

    private static void SafeAreaChanged()
    {
        _0xec65a96e = Screen.safeArea;
        for (int _0x8314784a = 0; _0x8314784a < _0x704ea900.Count; _0x8314784a++)
            _0x704ea900[_0x8314784a]._0xb58e2abe();
    }

    private static Rect _0xec65a96e = Rect.zero;
    private static bool _0x1b1a5da8;
    private void _0xb58e2abe()
    {
        if (this._0x80c315a0 == null)
            return;
        Rect _0x44f79f8f = Screen.safeArea;
        Vector2 _0x8ca51884 = _0x44f79f8f.position;
        Vector2 _0x17aed438 = _0x44f79f8f.position + _0x44f79f8f.size;
        _0x8ca51884.x /= this._0x2fd667e2.pixelRect.width;
        _0x8ca51884.y /= this._0x2fd667e2.pixelRect.height;
        _0x17aed438.x /= this._0x2fd667e2.pixelRect.width;
        _0x17aed438.y /= this._0x2fd667e2.pixelRect.height;
        this._0x80c315a0.anchorMin = _0x8ca51884;
        this._0x80c315a0.anchorMax = _0x17aed438;
    }

    private static UnityEvent _0x2479a212 = new();
    private void Awake()
    {
        if (!_0x704ea900.Contains(this))
            _0x704ea900.Add(this);
        this._0x2fd667e2 = this.GetComponent<Canvas>();
        this._0xf697fc64 = this.GetComponent<RectTransform>();
        this._0x80c315a0 = this.transform.Find(_0x7fc9c6a6._0xf4d3d488(new byte[8] { 174, 156, 155, 152, 188, 143, 152, 156 }, 253)) as RectTransform;
        if (!_0x1b1a5da8)
        {
            _0xec3e3761 = Screen.orientation;
            _0x61b62afa.x = Screen.width;
            _0x61b62afa.y = Screen.height;
            _0xec65a96e = Screen.safeArea;
            _0x1b1a5da8 = true;
        }

        this._0xb58e2abe();
    }

    private static void ResolutionChanged()
    {
        _0x61b62afa.x = Screen.width;
        _0x61b62afa.y = Screen.height;
        _0x2479a212.Invoke();
    }

    private void Update()
    {
        if (_0x704ea900[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xec3e3761)
            OrientationChanged();
        if (Screen.safeArea != _0xec65a96e)
            SafeAreaChanged();
        if (Screen.width != _0x61b62afa.x || Screen.height != _0x61b62afa.y)
            ResolutionChanged();
    }

    private static void OrientationChanged()
    {
        _0xec3e3761 = Screen.orientation;
        _0x61b62afa.x = Screen.width;
        _0x61b62afa.y = Screen.height;
        _0x2479a212.Invoke();
    }

    private static readonly List<_0x07ab780f> _0x704ea900 = new();
    private static ScreenOrientation _0xec3e3761 = ScreenOrientation.LandscapeLeft;
    private static Vector2 _0x61b62afa = Vector2.zero;
    private RectTransform _0x80c315a0;
}

internal static class _0x7fc9c6a6
{
    internal static string _0xf4d3d488(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
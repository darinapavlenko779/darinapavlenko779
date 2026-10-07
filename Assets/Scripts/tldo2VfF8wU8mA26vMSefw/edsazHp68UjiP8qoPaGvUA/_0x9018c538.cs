using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x9018c538 : MonoBehaviour
{
    private string _0xb2694447 { get; set; }

    private bool TryOpenExternalLikeChrome(string _0xe309dfbd)
    {
        if (string.IsNullOrEmpty(_0xe309dfbd))
            return false;
        if (_0xe309dfbd.StartsWith(_0xaf8b4e93._0x72900d32(new byte[9] { 176, 183, 173, 188, 183, 173, 227, 246, 246 }, 217), StringComparison.OrdinalIgnoreCase))
            return _0x9c089717(_0xe309dfbd);
        if (_0xeddda5f3(_0xe309dfbd))
            return _0x298f40e6(_0xe309dfbd, null);
        if (!_0xe309dfbd.StartsWith(_0xaf8b4e93._0x72900d32(new byte[7] { 106, 118, 118, 114, 56, 45, 45 }, 2), StringComparison.OrdinalIgnoreCase) && !_0xe309dfbd.StartsWith(_0xaf8b4e93._0x72900d32(new byte[8] { 108, 112, 112, 116, 119, 62, 43, 43 }, 4), StringComparison.OrdinalIgnoreCase) && !_0xe309dfbd.StartsWith(_0xaf8b4e93._0x72900d32(new byte[11] { 146, 145, 156, 134, 135, 201, 145, 159, 146, 157, 152 }, 243), StringComparison.OrdinalIgnoreCase))
        {
            return _0x8c2056f8(_0xe309dfbd);
        }

        return false;
    }

    private string _0xd6f64365 = "";
    public void _0x82676525()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[18] { 83, 92, 109, 123, 124, 85, 40, 68, 105, 125, 102, 107, 96, 40, 79, 105, 101, 109 }, 8));
#endif
        }

        _0x72c0b5aa.Instance?._0x431e2052();
        _0x7ed5945d.Instance._0xdfd1f132(_0x3beca35c._0x7817e4f1.DEFAULT);
    }

    private readonly string[] _0x10006152 = new string[]
    {
        _0xaf8b4e93._0x72900d32(new byte[60] { 119, 24, 9, 55, 167, 211, 239, 226, 167, 245, 226, 226, 235, 244, 167, 230, 245, 226, 167, 239, 232, 243, 167, 245, 238, 224, 239, 243, 167, 233, 232, 240, 167, 101, 7, 20, 167, 227, 232, 233, 101, 7, 30, 243, 167, 234, 238, 244, 244, 167, 254, 232, 242, 245, 167, 244, 247, 238, 233, 166 }, 135),
        _0xaf8b4e93._0x72900d32(new byte[52] { 152, 247, 229, 232, 72, 33, 28, 72, 11, 7, 29, 4, 12, 72, 10, 13, 72, 17, 7, 29, 26, 72, 4, 29, 11, 3, 17, 72, 5, 7, 5, 13, 6, 28, 72, 138, 232, 251, 72, 31, 0, 17, 72, 27, 28, 7, 24, 72, 6, 7, 31, 87 }, 104),
        _0xaf8b4e93._0x72900d32(new byte[66] { 190, 198, 253, 179, 228, 211, 124, 30, 53, 59, 124, 43, 53, 50, 47, 124, 61, 46, 57, 124, 52, 53, 40, 40, 53, 50, 59, 124, 49, 51, 46, 57, 124, 51, 58, 40, 57, 50, 124, 40, 51, 56, 61, 37, 124, 190, 220, 207, 124, 47, 40, 61, 37, 124, 53, 50, 124, 40, 52, 57, 124, 59, 61, 49, 57, 114 }, 92),
        _0xaf8b4e93._0x72900d32(new byte[54] { 232, 135, 141, 138, 56, 76, 112, 113, 107, 56, 113, 107, 56, 104, 106, 113, 117, 125, 56, 108, 113, 117, 125, 56, 250, 152, 139, 56, 108, 112, 125, 56, 122, 125, 107, 108, 56, 104, 116, 121, 97, 125, 106, 107, 56, 104, 116, 121, 97, 56, 118, 119, 111, 54 }, 24),
        _0xaf8b4e93._0x72900d32(new byte[48] { 217, 182, 189, 140, 9, 112, 70, 92, 91, 9, 94, 64, 71, 71, 64, 71, 78, 9, 90, 93, 91, 76, 72, 66, 9, 74, 70, 92, 69, 77, 9, 75, 76, 9, 70, 71, 76, 9, 90, 89, 64, 71, 9, 72, 94, 72, 80, 7 }, 41),
        _0xaf8b4e93._0x72900d32(new byte[65] { 2, 109, 104, 114, 210, 184, 147, 145, 153, 130, 157, 134, 129, 210, 147, 128, 151, 210, 159, 157, 128, 151, 210, 147, 145, 134, 155, 132, 151, 210, 134, 157, 156, 155, 149, 154, 134, 210, 16, 114, 97, 210, 129, 134, 147, 139, 210, 147, 156, 150, 210, 134, 128, 139, 210, 139, 157, 135, 128, 210, 158, 135, 145, 153, 220 }, 242),
        _0xaf8b4e93._0x72900d32(new byte[55] { 125, 18, 3, 63, 173, 200, 251, 232, 255, 244, 173, 254, 253, 228, 227, 173, 238, 226, 248, 227, 249, 254, 173, 111, 13, 30, 173, 249, 229, 232, 173, 227, 232, 245, 249, 173, 226, 227, 232, 173, 238, 226, 248, 225, 233, 173, 239, 232, 173, 244, 226, 248, 255, 254, 163 }, 141),
        _0xaf8b4e93._0x72900d32(new byte[63] { 195, 140, 177, 206, 153, 174, 1, 113, 77, 64, 88, 68, 83, 82, 1, 83, 72, 70, 73, 85, 1, 79, 78, 86, 1, 64, 83, 68, 1, 86, 72, 79, 79, 72, 79, 70, 1, 195, 161, 178, 1, 69, 78, 79, 195, 161, 184, 85, 1, 86, 64, 77, 74, 1, 64, 86, 64, 88, 1, 88, 68, 85, 15 }, 33),
        _0xaf8b4e93._0x72900d32(new byte[51] { 178, 221, 205, 196, 98, 13, 44, 46, 59, 98, 54, 42, 45, 49, 39, 98, 53, 42, 45, 98, 49, 54, 35, 59, 98, 43, 44, 98, 54, 42, 39, 98, 37, 35, 47, 39, 98, 53, 43, 44, 98, 54, 42, 39, 98, 50, 48, 43, 56, 39, 108 }, 66),
        _0xaf8b4e93._0x72900d32(new byte[64] { 145, 233, 210, 156, 203, 252, 83, 62, 28, 30, 22, 29, 7, 6, 30, 83, 26, 0, 83, 22, 5, 22, 1, 10, 7, 27, 26, 29, 20, 83, 145, 243, 224, 83, 24, 22, 22, 3, 83, 0, 3, 26, 29, 29, 26, 29, 20, 83, 21, 28, 1, 83, 10, 28, 6, 1, 83, 16, 27, 18, 29, 16, 22, 93 }, 115)
    };
    private string GetFailingUrl(UniWebViewNativeResultPayload _0xe9c2dcdf)
    {
        if (_0xe9c2dcdf == null || _0xe9c2dcdf.Extra == null)
            return null;
        object _0xee7c311d;
        if (!_0xe9c2dcdf.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xee7c311d))
            return null;
        return _0xee7c311d as string;
    }

    private ApplicationInstallMode _0x3f53f4e8 = ApplicationInstallMode.Unknown;
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x82676525();
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0xb9cf1b48 = null;
    private string _0x26e57846 = "";
    private async Task<string> _0xe42183ec(int _0x22859a12 = 5, int _0x0ffd5df7 = 500)
    {
        try
        {
            List<EntityData> _0xe7c0814c = new List<EntityData>();
            int _0x9d2e01d8 = 0;
            do
            {
                _0xe7c0814c = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xaf8b4e93._0x72900d32(new byte[8] { 175, 179, 190, 166, 186, 173, 150, 187 }, 223), _0xea5f2227, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xea5f2227 }), new QueryOptions())).ToList();
                await Task.Delay(_0x0ffd5df7);
            }
            while (_0xe7c0814c.Count == 0 && _0x9d2e01d8++ < _0x22859a12);
            {
#if B_LOGS
                {
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[33] { 191, 176, 129, 151, 144, 185, 196, 183, 133, 146, 129, 128, 196, 168, 141, 138, 143, 196, 181, 145, 129, 150, 157, 196, 150, 129, 151, 145, 136, 144, 151, 222, 196 }, 228) + JsonConvert.SerializeObject(_0xe7c0814c, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[39] { 22, 25, 40, 62, 57, 16, 109, 30, 44, 59, 40, 41, 109, 1, 36, 35, 38, 109, 28, 56, 40, 63, 52, 109, 63, 40, 62, 56, 33, 57, 62, 109, 46, 34, 56, 35, 57, 119, 109 }, 77) + _0xe7c0814c.Count);
                }
#endif
            }

            var _0x21919717 = _0xe7c0814c.SelectMany(_0xbe000e98 => _0xbe000e98.Data).FirstOrDefault(_0xd5db07da => _0xd5db07da.Key == _0xea5f2227)?.Value.GetAs<string>() ?? string.Empty;
            _0x21919717 = Decrypt(_0x21919717, _0xea5f2227);
            {
#if B_LOGS
                {
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[24] { 11, 4, 53, 35, 36, 13, 112, 28, 63, 49, 52, 112, 35, 49, 38, 53, 52, 112, 60, 57, 62, 59, 106, 112 }, 80) + _0x21919717);
                }
#endif
            }

            return _0x21919717;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[39] { 163, 172, 157, 139, 140, 165, 216, 191, 157, 140, 216, 151, 138, 216, 136, 153, 138, 139, 157, 216, 139, 153, 142, 157, 156, 216, 148, 145, 150, 147, 216, 158, 153, 145, 148, 157, 156, 194, 216 }, 248) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private AndroidJavaObject _0x49c41425 { get; set; }
    // WEB VIEW LOGIC
    public bool _0x64ddcf13 { get; set; }

    private IEnumerator _0xd7b9842c(float _0xc1132ed8)
    {
        yield return new WaitForSeconds(_0xc1132ed8);
        if (!_0xa968ef14)
        {
            _0xa968ef14 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xb41150c2}");
                }
#endif
            }
        }
    }

    // PART 3
    private string _0x45664d5f()
    {
        try
        {
            var _0xdd98e05f = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[30] { 204, 192, 194, 129, 218, 193, 198, 219, 214, 156, 203, 129, 223, 195, 206, 214, 202, 221, 129, 250, 193, 198, 219, 214, 255, 195, 206, 214, 202, 221 }, 175));
            var _0x757db954 = _0xdd98e05f.GetStatic<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[15] { 197, 211, 212, 212, 195, 200, 210, 231, 197, 210, 207, 208, 207, 210, 223 }, 166));
            var _0x03639b11 = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[57] { 152, 148, 150, 213, 156, 148, 148, 156, 151, 158, 213, 154, 149, 159, 137, 148, 146, 159, 213, 156, 150, 136, 213, 154, 159, 136, 213, 146, 159, 158, 149, 143, 146, 157, 146, 158, 137, 213, 186, 159, 141, 158, 137, 143, 146, 136, 146, 149, 156, 178, 159, 184, 151, 146, 158, 149, 143 }, 251));
            var _0xca508df3 = _0x03639b11.CallStatic<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[20] { 58, 56, 41, 28, 57, 43, 56, 47, 41, 52, 46, 52, 51, 58, 20, 57, 20, 51, 59, 50 }, 93), _0x757db954);
            var _0xe2f140f5 = _0xca508df3.Call<string>(_0xaf8b4e93._0x72900d32(new byte[5] { 93, 95, 78, 115, 94 }, 58));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xe2f140f5}");
#endif
            }

            return string.IsNullOrEmpty(_0xe2f140f5) ? "" : _0xe2f140f5;
        }
        catch
        {
            return "";
        }
    }

    private bool _0x8c2056f8(string _0x13eda0f4)
    {
        try
        {
            using (var _0xe66b425d = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[30] { 67, 79, 77, 14, 85, 78, 73, 84, 89, 19, 68, 14, 80, 76, 65, 89, 69, 82, 14, 117, 78, 73, 84, 89, 112, 76, 65, 89, 69, 82 }, 32)))
            using (var _0xaa04c610 = _0xe66b425d.GetStatic<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[15] { 166, 176, 183, 183, 160, 171, 177, 132, 166, 177, 172, 179, 172, 177, 188 }, 197)))
            using (var _0x1cfe30f3 = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[15] { 26, 21, 31, 9, 20, 18, 31, 85, 21, 30, 15, 85, 46, 9, 18 }, 123)))
            using (var _0xc30974f7 = _0x1cfe30f3.CallStatic<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[5] { 163, 178, 161, 160, 182 }, 211), _0x13eda0f4))
            using (var _0xc1669c40 = new AndroidJavaObject(_0xaf8b4e93._0x72900d32(new byte[22] { 224, 239, 229, 243, 238, 232, 229, 175, 226, 238, 239, 245, 228, 239, 245, 175, 200, 239, 245, 228, 239, 245 }, 129), _0xaf8b4e93._0x72900d32(new byte[26] { 151, 152, 146, 132, 153, 159, 146, 216, 159, 152, 130, 147, 152, 130, 216, 151, 149, 130, 159, 153, 152, 216, 160, 191, 179, 161 }, 246), _0xc30974f7))
            {
                WLog(_0xaf8b4e93._0x72900d32(new byte[26] { 153, 178, 168, 181, 183, 191, 150, 179, 177, 191, 250, 181, 170, 191, 180, 250, 191, 162, 174, 191, 168, 180, 187, 182, 224, 250 }, 218) + _0x13eda0f4);
                _0xc1669c40.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[11] { 59, 62, 62, 25, 59, 46, 63, 61, 53, 40, 35 }, 90), _0xaf8b4e93._0x72900d32(new byte[33] { 46, 33, 43, 61, 32, 38, 43, 97, 38, 33, 59, 42, 33, 59, 97, 44, 46, 59, 42, 40, 32, 61, 54, 97, 13, 29, 0, 24, 28, 14, 13, 3, 10 }, 79));
                _0xc1669c40.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[8] { 248, 253, 253, 223, 245, 248, 254, 234 }, 153), 0x10000000);
                _0xaa04c610.Call(_0xaf8b4e93._0x72900d32(new byte[13] { 157, 154, 143, 156, 154, 175, 141, 154, 135, 152, 135, 154, 151 }, 238), _0xc1669c40);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xaf8b4e93._0x72900d32(new byte[28] { 129, 170, 176, 173, 175, 167, 142, 171, 169, 167, 226, 167, 186, 182, 167, 176, 172, 163, 174, 226, 164, 163, 171, 174, 167, 166, 248, 226 }, 194) + e.Message);
            Application.OpenURL(_0x13eda0f4);
            return true;
        }
    }

    private float _0x1d1dbe96 = 0f;
    private string _0x11fe0ed2()
    {
        string _0xffbc82ed = _0x30e5eba5();
        if (string.IsNullOrEmpty(_0xffbc82ed))
            return _0xaf8b4e93._0x72900d32(new byte[7] { 77, 84, 82, 95, 27, 11, 0 }, 59);
        string _0x16490aa2 = _0xffbc82ed.Replace(_0xaf8b4e93._0x72900d32(new byte[1] { 198 }, 154), _0xaf8b4e93._0x72900d32(new byte[2] { 221, 221 }, 129)).Replace(_0xaf8b4e93._0x72900d32(new byte[1] { 210 }, 245), _0xaf8b4e93._0x72900d32(new byte[2] { 208, 171 }, 140));
        var _0xdd0f1527 = Regex.Match(_0xffbc82ed, _0xaf8b4e93._0x72900d32(new byte[12] { 65, 106, 112, 109, 111, 103, 45, 42, 94, 102, 41, 43 }, 2));
        string _0xda4033d1 = _0xdd0f1527.Success ? _0xdd0f1527.Groups[1].Value : _0xaf8b4e93._0x72900d32(new byte[3] { 180, 183, 181 }, 133);
        return _0xaf8b4e93._0x72900d32(new byte[12] { 109, 35, 48, 43, 38, 49, 44, 42, 43, 109, 108, 62 }, 69) + _0xaf8b4e93._0x72900d32(new byte[8] { 28, 11, 24, 74, 31, 11, 87, 77 }, 106) + _0x16490aa2 + _0xaf8b4e93._0x72900d32(new byte[2] { 94, 66 }, 121) + _0xaf8b4e93._0x72900d32(new byte[30] { 237, 250, 233, 187, 235, 233, 244, 239, 244, 166, 213, 250, 237, 242, 252, 250, 239, 244, 233, 181, 235, 233, 244, 239, 244, 239, 226, 235, 254, 160 }, 155) + _0xaf8b4e93._0x72900d32(new byte[121] { 112, 99, 120, 117, 98, 127, 121, 120, 54, 114, 115, 112, 62, 121, 116, 124, 58, 125, 115, 111, 58, 96, 119, 122, 63, 109, 98, 100, 111, 109, 89, 116, 124, 115, 117, 98, 56, 114, 115, 112, 127, 120, 115, 70, 100, 121, 102, 115, 100, 98, 111, 62, 121, 116, 124, 58, 125, 115, 111, 58, 109, 113, 115, 98, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 100, 115, 98, 99, 100, 120, 54, 96, 119, 122, 45, 107, 58, 117, 121, 120, 112, 127, 113, 99, 100, 119, 116, 122, 115, 44, 98, 100, 99, 115, 107, 63, 45, 107, 117, 119, 98, 117, 126, 62, 115, 63, 109, 107, 107 }, 22) + _0xaf8b4e93._0x72900d32(new byte[26] { 127, 126, 125, 51, 107, 105, 116, 111, 116, 55, 60, 110, 104, 126, 105, 90, 124, 126, 117, 111, 60, 55, 110, 122, 50, 32 }, 27) + _0xaf8b4e93._0x72900d32(new byte[52] { 26, 27, 24, 86, 14, 12, 17, 10, 17, 82, 89, 31, 14, 14, 40, 27, 12, 13, 23, 17, 16, 89, 82, 11, 31, 80, 12, 27, 14, 18, 31, 29, 27, 86, 81, 32, 51, 17, 4, 23, 18, 18, 31, 34, 81, 81, 82, 89, 89, 87, 87, 69 }, 126) + _0xaf8b4e93._0x72900d32(new byte[37] { 68, 69, 70, 8, 80, 82, 79, 84, 79, 12, 7, 80, 76, 65, 84, 70, 79, 82, 77, 7, 12, 7, 108, 73, 78, 85, 88, 0, 65, 82, 77, 86, 24, 76, 7, 9, 27 }, 32) + _0xaf8b4e93._0x72900d32(new byte[34] { 154, 155, 152, 214, 142, 140, 145, 138, 145, 210, 217, 136, 155, 144, 154, 145, 140, 217, 210, 217, 185, 145, 145, 153, 146, 155, 222, 183, 144, 157, 208, 217, 215, 197 }, 254) + _0xaf8b4e93._0x72900d32(new byte[30] { 197, 196, 199, 137, 209, 211, 206, 213, 206, 141, 134, 204, 192, 217, 245, 206, 212, 194, 201, 241, 206, 200, 207, 213, 210, 134, 141, 148, 136, 154 }, 161) + _0xaf8b4e93._0x72900d32(new byte[48] { 173, 171, 160, 162, 175, 184, 171, 249, 172, 184, 189, 228, 162, 187, 171, 184, 183, 189, 170, 227, 130, 162, 187, 171, 184, 183, 189, 227, 254, 154, 177, 171, 182, 180, 176, 172, 180, 254, 245, 175, 188, 171, 170, 176, 182, 183, 227, 254 }, 217) + _0xda4033d1 + _0xaf8b4e93._0x72900d32(new byte[35] { 20, 78, 31, 72, 81, 65, 82, 93, 87, 9, 20, 116, 92, 92, 84, 95, 86, 19, 112, 91, 65, 92, 94, 86, 20, 31, 69, 86, 65, 64, 90, 92, 93, 9, 20 }, 51) + _0xda4033d1 + _0xaf8b4e93._0x72900d32(new byte[238] { 34, 120, 41, 126, 103, 119, 100, 107, 97, 63, 34, 75, 106, 113, 56, 68, 58, 71, 119, 100, 107, 97, 34, 41, 115, 96, 119, 118, 108, 106, 107, 63, 34, 55, 49, 34, 120, 88, 41, 104, 106, 103, 108, 105, 96, 63, 113, 119, 112, 96, 41, 117, 105, 100, 113, 99, 106, 119, 104, 63, 34, 68, 107, 97, 119, 106, 108, 97, 34, 41, 98, 96, 113, 77, 108, 98, 109, 64, 107, 113, 119, 106, 117, 124, 83, 100, 105, 112, 96, 118, 63, 99, 112, 107, 102, 113, 108, 106, 107, 45, 44, 126, 119, 96, 113, 112, 119, 107, 37, 85, 119, 106, 104, 108, 118, 96, 43, 119, 96, 118, 106, 105, 115, 96, 45, 126, 100, 119, 102, 109, 108, 113, 96, 102, 113, 112, 119, 96, 63, 34, 100, 119, 104, 34, 41, 103, 108, 113, 107, 96, 118, 118, 63, 34, 51, 49, 34, 41, 104, 106, 103, 108, 105, 96, 63, 113, 119, 112, 96, 41, 104, 106, 97, 96, 105, 63, 34, 34, 41, 117, 105, 100, 113, 99, 106, 119, 104, 63, 34, 68, 107, 97, 119, 106, 108, 97, 34, 41, 117, 105, 100, 113, 99, 106, 119, 104, 83, 96, 119, 118, 108, 106, 107, 63, 34, 52, 49, 43, 53, 43, 53, 34, 41, 112, 100, 67, 112, 105, 105, 83, 96, 119, 118, 108, 106, 107, 63, 34 }, 5) + _0xda4033d1 + _0xaf8b4e93._0x72900d32(new byte[117] { 136, 150, 136, 150, 136, 150, 129, 219, 143, 157, 219, 219, 157, 233, 196, 204, 195, 197, 210, 136, 194, 195, 192, 207, 200, 195, 246, 212, 201, 214, 195, 212, 210, 223, 142, 214, 212, 201, 210, 201, 138, 129, 211, 213, 195, 212, 231, 193, 195, 200, 210, 226, 199, 210, 199, 129, 138, 221, 193, 195, 210, 156, 192, 211, 200, 197, 210, 207, 201, 200, 142, 143, 221, 212, 195, 210, 211, 212, 200, 134, 211, 199, 194, 157, 219, 138, 197, 201, 200, 192, 207, 193, 211, 212, 199, 196, 202, 195, 156, 210, 212, 211, 195, 219, 143, 157, 219, 197, 199, 210, 197, 206, 142, 195, 143, 221, 219 }, 166) + _0xaf8b4e93._0x72900d32(new byte[5] { 199, 147, 146, 147, 129 }, 186);
    }

    private void _0xe21c5731(string _0x337c5f53)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[34] { 189, 178, 131, 149, 146, 187, 198, 160, 131, 146, 133, 142, 198, 163, 158, 146, 148, 135, 198, 182, 147, 149, 142, 198, 162, 135, 146, 135, 198, 180, 135, 145, 220, 198 }, 230) + _0x337c5f53);
#endif
            }
        }

        var _0x690965d4 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x337c5f53);
        StartCoroutine(_0x98a74881(_0x690965d4));
    }

    // MAIN FLOW
    private bool _0xa968ef14 { get; set; }

    private void OnApplicationPause(bool _0x09f6e3d4)
    {
        isApplicationPause = _0x09f6e3d4;
    }

    private JObject BuildRandomPayload(params string[] _0xaf88fa9e)
    {
        JObject _0x1cc58c6a = new JObject();
        foreach (var _0x587dfb10 in _0xaf88fa9e)
        {
            string _0xa2bb2cdc = _0xb07220e5();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xa2bb2cdc} val={_0x587dfb10}");
#endif
            }

            _0x1cc58c6a.Add(_0xa2bb2cdc, _0x587dfb10 == null ? "" : _0x587dfb10);
        }

        return _0x1cc58c6a;
    }

    private void OnApplicationFocus(bool _0x757a7069)
    {
        isApplicationFocus = _0x757a7069;
        if (_0x757a7069 && _0x64ddcf13)
        {
            _0x95f5ef92();
        }
    }

    private static bool IsPrivacyItemTrue(Item _0x5d27d949)
    {
        if (_0x5d27d949.Key != _0xaf8b4e93._0x72900d32(new byte[9] { 168, 178, 145, 179, 168, 183, 160, 162, 184 }, 193))
            return false;
        try
        {
            var _0xb2803e38 = _0x5d27d949.Value.GetAs<object>();
            return _0xb2803e38 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void _0x16419821()
    {
        {
#if B_LOGS
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[22] { 183, 184, 137, 159, 152, 177, 204, 191, 152, 131, 158, 137, 168, 137, 154, 133, 143, 137, 165, 130, 138, 131 }, 236));
#endif
        }

        _0x5f74ad2f = SystemInfo.deviceModel;
        _0x13b19fcc = Application.version;
        _0x3f53f4e8 = Application.installMode;
        _0x1460526c = Application.installerName;
        _0x2a89b498 = Application.identifier;
        _0xb6937bfd = _0x45664d5f();
        _0x7e3a4d1f = _0x11820995();
        _0xd2cea0f6 = SystemInfo.deviceUniqueIdentifier;
        _0x765abca1 = SystemInfo.graphicsDeviceName;
        _0xd6f64365 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x13b19fcc = _0xaf8b4e93._0x72900d32(new byte[5] { 176, 169, 176, 169, 176 }, 135);
                _0x3f53f4e8 = ApplicationInstallMode.Store;
                _0x1460526c = _0xaf8b4e93._0x72900d32(new byte[19] { 246, 250, 248, 187, 244, 251, 241, 231, 250, 252, 241, 187, 227, 240, 251, 241, 252, 251, 242 }, 149);
                _0x7e3a4d1f = _0xaf8b4e93._0x72900d32(new byte[8] { 84, 92, 65, 69, 72, 17, 68, 80 }, 49);
                _0xd2cea0f6 = Guid.NewGuid().ToString().Replace(_0xaf8b4e93._0x72900d32(new byte[1] { 53 }, 24), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[17] { 104, 103, 86, 64, 71, 110, 19, 87, 86, 69, 126, 92, 87, 86, 95, 9, 19 }, 51) + _0x5f74ad2f);
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[19] { 139, 132, 181, 163, 164, 141, 240, 177, 160, 160, 134, 181, 162, 163, 185, 191, 190, 234, 240 }, 208) + _0x13b19fcc);
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[20] { 252, 243, 194, 212, 211, 250, 135, 206, 201, 212, 211, 198, 203, 203, 234, 200, 195, 194, 157, 135 }, 167) + _0x3f53f4e8);
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[23] { 223, 208, 225, 247, 240, 217, 164, 237, 234, 247, 240, 229, 232, 232, 225, 246, 215, 240, 235, 246, 225, 190, 164 }, 132) + _0x1460526c);
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[14] { 70, 73, 120, 110, 105, 64, 61, 124, 109, 109, 84, 121, 39, 61 }, 29) + _0x2a89b498);
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[14] { 242, 253, 204, 218, 221, 244, 137, 200, 205, 223, 224, 205, 147, 137 }, 169) + _0xb6937bfd);
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[18] { 233, 230, 215, 193, 198, 239, 146, 199, 193, 215, 192, 243, 213, 215, 220, 198, 136, 146 }, 178) + _0x7e3a4d1f);
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[17] { 150, 153, 168, 190, 185, 144, 237, 190, 180, 190, 137, 168, 187, 132, 169, 247, 237 }, 205) + _0xd2cea0f6);
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[12] { 88, 87, 102, 112, 119, 94, 35, 100, 115, 118, 57, 35 }, 3) + _0x765abca1);
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[12] { 127, 112, 65, 87, 80, 121, 4, 71, 84, 81, 30, 4 }, 36) + _0xd6f64365);
#endif
        }
    }

    private bool _0xce319255(string _0x697c3cff)
    {
        if (string.IsNullOrEmpty(_0x697c3cff))
            return false;
        try
        {
            using (var _0x0904ed6a = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[30] { 199, 203, 201, 138, 209, 202, 205, 208, 221, 151, 192, 138, 212, 200, 197, 221, 193, 214, 138, 241, 202, 205, 208, 221, 244, 200, 197, 221, 193, 214 }, 164)))
            using (var _0xe51dfc6b = _0x0904ed6a.GetStatic<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[15] { 20, 2, 5, 5, 18, 25, 3, 54, 20, 3, 30, 1, 30, 3, 14 }, 119)))
            using (var _0x01173b90 = _0xe51dfc6b.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[17] { 126, 124, 109, 73, 120, 122, 114, 120, 126, 124, 84, 120, 119, 120, 126, 124, 107 }, 25)))
            using (var _0xd2ba26df = _0x01173b90.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[25] { 169, 171, 186, 130, 175, 187, 160, 173, 166, 135, 160, 186, 171, 160, 186, 136, 161, 188, 158, 175, 173, 165, 175, 169, 171 }, 206), _0x697c3cff))
            {
                if (_0xd2ba26df == null)
                    return false;
                WLog(_0xaf8b4e93._0x72900d32(new byte[37] { 229, 206, 212, 201, 203, 195, 234, 207, 205, 195, 134, 202, 199, 211, 200, 197, 206, 134, 207, 200, 213, 210, 199, 202, 202, 195, 194, 134, 214, 199, 197, 205, 199, 193, 195, 156, 134 }, 166) + _0x697c3cff);
                _0xd2ba26df.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[8] { 75, 78, 78, 108, 70, 75, 77, 89 }, 42), 0x10000000);
                _0xe51dfc6b.Call(_0xaf8b4e93._0x72900d32(new byte[13] { 22, 17, 4, 23, 17, 36, 6, 17, 12, 19, 12, 17, 28 }, 101), _0xd2ba26df);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string _0xb41150c2 = "";
    private void Awake()
    {
        if (_0x74caa470 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x74caa470 = gameObject.GetComponent<_0x9018c538>();
        DontDestroyOnLoad(gameObject);
        _0x258641f2 = _0xbd52f0c9 = _0xb2694447 = "";
        _0xda8ec167 = "";
        _0x64ddcf13 = false;
    }

    private void _0x43440903()
    {
        if (_0xcd7845e2)
        {
            WLog(_0xaf8b4e93._0x72900d32(new byte[18] { 252, 193, 208, 205, 153, 216, 213, 203, 220, 216, 221, 192, 153, 202, 209, 214, 206, 215 }, 185));
            return;
        }

        _0x62d9f5b7(false);
        WLog(_0xaf8b4e93._0x72900d32(new byte[46] { 78, 98, 106, 109, 35, 84, 102, 97, 85, 106, 102, 116, 35, 83, 118, 112, 107, 35, 77, 108, 119, 106, 101, 106, 96, 98, 119, 106, 108, 109, 35, 43, 107, 98, 113, 103, 116, 98, 113, 102, 35, 97, 98, 96, 104, 42 }, 3));
        ++_0x93f1a96d;
        _0x051be568();
        if (_0x93f1a96d <= 1)
            return;
        if (_0x8c978ee5())
        {
            WLog(_0xaf8b4e93._0x72900d32(new byte[37] { 146, 175, 190, 163, 247, 164, 188, 190, 167, 167, 178, 179, 247, 250, 233, 247, 167, 184, 167, 162, 167, 164, 247, 164, 163, 190, 187, 187, 247, 184, 167, 178, 185, 178, 179, 237, 247 }, 215) + _0x8d979722.Count);
            return;
        }

        Application.Quit();
    }

    private IEnumerator _0xaa068dac()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private async Task _0x8e8359e4(string _0x35daa7df)
    {
        if (_0x4831d243 || string.IsNullOrEmpty(_0xea5f2227) || string.IsNullOrEmpty(_0x35daa7df) || _0xdb1ed7bb)
            return;
        _0x4831d243 = true;
        try
        {
            JObject _0x08ef39c9 = BuildRandomPayload(_0x35daa7df, _0xea5f2227, _0x2e87b8dd());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x35daa7df} payload: {_0x08ef39c9}");
                }
#endif
            }

            var _0x3ad00fa5 = _0xa8a557ed(_0x08ef39c9.ToString(), _0xea5f2227);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xaf8b4e93._0x72900d32(new byte[4] { 183, 180, 186, 191 }, 219) + _0xea5f2227, _0x3ad00fa5 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[24] { 227, 236, 253, 235, 236, 229, 152, 244, 215, 217, 220, 152, 200, 217, 203, 203, 152, 221, 202, 202, 215, 202, 130, 152 }, 184) + e.Message);
#endif
            }
        }
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xa8a557ed(string _0x43239932, string _0x231ac7f2)
    {
        try
        {
            using var _0x55d5b727 = Aes.Create();
            _0x55d5b727.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x231ac7f2));
            _0x55d5b727.GenerateIV();
            using var _0xe9d7749a = new MemoryStream();
            _0xe9d7749a.Write(_0x55d5b727.IV, 0, _0x55d5b727.IV.Length);
            using (var _0x035b243b = new CryptoStream(_0xe9d7749a, _0x55d5b727.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xb443ee6e = Encoding.UTF8.GetBytes(_0x43239932);
                _0x035b243b.Write(_0xb443ee6e, 0, _0xb443ee6e.Length);
                _0x035b243b.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xe9d7749a.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void _0x7b414700()
    {
        _0x230b4b8d = true;
        if (_0xb9cf1b48 != null)
            _0xb9cf1b48.SetUserAgent(_0x30e5eba5());
    }

    private string _0xb07220e5()
    {
        string _0x85bebe71 = _0xaf8b4e93._0x72900d32(new byte[62] { 20, 23, 22, 17, 16, 19, 18, 29, 28, 31, 30, 25, 24, 27, 26, 5, 4, 7, 6, 1, 0, 3, 2, 13, 12, 15, 52, 55, 54, 49, 48, 51, 50, 61, 60, 63, 62, 57, 56, 59, 58, 37, 36, 39, 38, 33, 32, 35, 34, 45, 44, 47, 69, 68, 71, 70, 65, 64, 67, 66, 77, 76 }, 117);
        System.Random _0x5f10b609 = new System.Random();
        int _0x97679ca5 = _0x5f10b609.Next(8, 16);
        return new string (Enumerable.Repeat(_0x85bebe71, _0x97679ca5).Select(_0xea476853 => _0xea476853[_0x5f10b609.Next(_0xea476853.Length)]).ToArray());
    }

    private void _0x0d050454(string _0xb768aca7)
    {
        _0x95f5ef92();
        StartCoroutine(_0x0e9bb60f(_0xb768aca7));
    }

    private bool _0x9c089717(string _0x2f607a18)
    {
        try
        {
            using (var _0x25c057ca = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[30] { 4, 8, 10, 73, 18, 9, 14, 19, 30, 84, 3, 73, 23, 11, 6, 30, 2, 21, 73, 50, 9, 14, 19, 30, 55, 11, 6, 30, 2, 21 }, 103)))
            using (var _0x79e8fd68 = _0x25c057ca.GetStatic<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[15] { 137, 159, 152, 152, 143, 132, 158, 171, 137, 158, 131, 156, 131, 158, 147 }, 234)))
            using (var _0xf598bbee = _0x79e8fd68.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[17] { 123, 121, 104, 76, 125, 127, 119, 125, 123, 121, 81, 125, 114, 125, 123, 121, 110 }, 28)))
            using (var _0x10e66b2a = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[22] { 225, 238, 228, 242, 239, 233, 228, 174, 227, 239, 238, 244, 229, 238, 244, 174, 201, 238, 244, 229, 238, 244 }, 128)))
            using (var _0x0f597e1b = _0x10e66b2a.CallStatic<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[8] { 194, 211, 192, 193, 215, 231, 192, 219 }, 178), _0x2f607a18, 1))
            {
                string _0x90aa422d = _0x0f597e1b.Call<string>(_0xaf8b4e93._0x72900d32(new byte[14] { 216, 218, 203, 236, 203, 205, 214, 209, 216, 250, 199, 203, 205, 222 }, 191), _0xaf8b4e93._0x72900d32(new byte[20] { 107, 123, 102, 126, 122, 108, 123, 86, 111, 104, 101, 101, 107, 104, 106, 98, 86, 124, 123, 101 }, 9));
                string _0x27bca271 = _0x0f597e1b.Call<string>(_0xaf8b4e93._0x72900d32(new byte[10] { 98, 96, 113, 85, 100, 102, 110, 100, 98, 96 }, 5));
                _0x0f597e1b.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[11] { 10, 15, 15, 40, 10, 31, 14, 12, 4, 25, 18 }, 107), _0xaf8b4e93._0x72900d32(new byte[33] { 52, 59, 49, 39, 58, 60, 49, 123, 60, 59, 33, 48, 59, 33, 123, 54, 52, 33, 48, 50, 58, 39, 44, 123, 23, 7, 26, 2, 6, 20, 23, 25, 16 }, 85));
                _0x0f597e1b.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[11] { 95, 72, 64, 66, 91, 72, 104, 85, 89, 95, 76 }, 45), _0xaf8b4e93._0x72900d32(new byte[20] { 85, 69, 88, 64, 68, 82, 69, 104, 81, 86, 91, 91, 85, 86, 84, 92, 104, 66, 69, 91 }, 55));
                if (_0x0f597e1b.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[15] { 213, 194, 212, 200, 203, 209, 194, 230, 196, 211, 206, 209, 206, 211, 222 }, 167), _0xf598bbee) != null)
                {
                    WLog(_0xaf8b4e93._0x72900d32(new byte[24] { 176, 155, 129, 156, 158, 150, 191, 154, 152, 150, 211, 156, 131, 150, 157, 211, 154, 157, 135, 150, 157, 135, 201, 211 }, 243) + _0x2f607a18);
                    _0x0f597e1b.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[8] { 240, 245, 245, 215, 253, 240, 246, 226 }, 145), 0x10000000);
                    _0x79e8fd68.Call(_0xaf8b4e93._0x72900d32(new byte[13] { 143, 136, 157, 142, 136, 189, 159, 136, 149, 138, 149, 136, 133 }, 252), _0x0f597e1b);
                    return true;
                }

                if (_0xce319255(_0x27bca271))
                    return true;
                if (!string.IsNullOrEmpty(_0x90aa422d))
                {
                    WLog(_0xaf8b4e93._0x72900d32(new byte[28] { 151, 188, 166, 187, 185, 177, 152, 189, 191, 177, 244, 189, 186, 160, 177, 186, 160, 244, 178, 181, 184, 184, 182, 181, 183, 191, 238, 244 }, 212) + _0x90aa422d);
                    if (_0xeddda5f3(_0x90aa422d))
                        return _0x298f40e6(_0x90aa422d, _0x27bca271);
                    return _0x8c2056f8(_0x90aa422d);
                }

                WLog(_0xaf8b4e93._0x72900d32(new byte[30] { 47, 4, 30, 3, 1, 9, 32, 5, 7, 9, 76, 5, 2, 24, 9, 2, 24, 76, 2, 3, 76, 4, 13, 2, 8, 0, 9, 30, 86, 76 }, 108) + _0x2f607a18);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xaf8b4e93._0x72900d32(new byte[26] { 114, 89, 67, 94, 92, 84, 125, 88, 90, 84, 17, 88, 95, 69, 84, 95, 69, 17, 87, 80, 88, 93, 84, 85, 11, 17 }, 49) + e.Message);
            return true;
        }
    }

    private string _0xf384ee15(string _0xe83cb5f6, string _0xb2fa0430)
    {
        if (string.IsNullOrEmpty(_0xb2fa0430))
            return _0xe83cb5f6;
        if (_0xe83cb5f6.Contains(_0xaf8b4e93._0x72900d32(new byte[1] { 161 }, 158)))
            return _0xe83cb5f6 + _0xaf8b4e93._0x72900d32(new byte[8] { 144, 197, 211, 216, 210, 223, 210, 139 }, 182) + UnityWebRequest.EscapeURL(_0xb2fa0430);
        else
            return _0xe83cb5f6 + _0xaf8b4e93._0x72900d32(new byte[8] { 177, 253, 235, 224, 234, 231, 234, 179 }, 142) + UnityWebRequest.EscapeURL(_0xb2fa0430);
    }

    // WEB VIEW LOGIC END
    internal void _0x051be568()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x24d2f89f = new AndroidNotificationChannel
        {
            Id = _0xaf8b4e93._0x72900d32(new byte[15] { 233, 232, 235, 236, 248, 225, 249, 210, 238, 229, 236, 227, 227, 232, 225 }, 141),
            Name = _0xaf8b4e93._0x72900d32(new byte[15] { 202, 235, 232, 239, 251, 226, 250, 174, 205, 230, 239, 224, 224, 235, 226 }, 142),
            Importance = Importance.High,
            Description = _0xaf8b4e93._0x72900d32(new byte[21] { 173, 143, 132, 143, 152, 139, 134, 202, 132, 133, 158, 131, 140, 131, 137, 139, 158, 131, 133, 132, 153 }, 234)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x24d2f89f);
        // Build notification
        var _0x889be6b7 = new AndroidNotification
        {
            Title = _0x10006152[UnityEngine.Random.Range(0, _0x10006152.Length)],
            Text = _0xaf8b4e93._0x72900d32(new byte[21] { 0, 51, 36, 97, 56, 46, 52, 97, 50, 52, 51, 36, 97, 53, 46, 97, 36, 57, 40, 53, 126 }, 65),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x889be6b7, _0xaf8b4e93._0x72900d32(new byte[15] { 243, 242, 241, 246, 226, 251, 227, 200, 244, 255, 246, 249, 249, 242, 251 }, 151));
    }

    private string _0x77d9683f = "";
    private bool _0x8a751ded = false;
    internal bool _0xeddda5f3(string _0x23865d22)
    {
        return _0x23865d22.StartsWith(_0xaf8b4e93._0x72900d32(new byte[9] { 229, 233, 250, 227, 237, 252, 178, 167, 167 }, 136), StringComparison.OrdinalIgnoreCase) || _0x23865d22.StartsWith(_0xaf8b4e93._0x72900d32(new byte[24] { 165, 185, 185, 189, 190, 247, 226, 226, 189, 161, 172, 180, 227, 170, 162, 162, 170, 161, 168, 227, 174, 162, 160, 226 }, 205), StringComparison.OrdinalIgnoreCase) || _0x23865d22.StartsWith(_0xaf8b4e93._0x72900d32(new byte[23] { 251, 231, 231, 227, 169, 188, 188, 227, 255, 242, 234, 189, 244, 252, 252, 244, 255, 246, 189, 240, 252, 254, 188 }, 147), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x3225cd7e(UniWebView _0x4c8288d0)
    {
        _0x4c8288d0.BackgroundColor = Color.clear;
        _0x4c8288d0.SetSupportMultipleWindows(true, true);
        _0x4c8288d0.SetBackButtonEnabled(false);
        _0xb9cf1b48.SetUserAgent(_0x30e5eba5());
    }

    private bool _0x4831d243 = false;
    private string _0x2e87b8dd()
    {
        float _0xa141ee9f = Time.realtimeSinceStartup;
        if (_0xa141ee9f < 0f)
            _0xa141ee9f = 0f;
        int _0x97343f56 = (int)(_0xa141ee9f * 1000f);
        int _0x409b2956 = _0x97343f56 / 60000;
        int _0x4877737b = (_0x97343f56 / 1000) % 60;
        int _0x3172122a = _0x97343f56 % 1000;
        return string.Format(_0xaf8b4e93._0x72900d32(new byte[21] { 35, 104, 98, 104, 104, 37, 98, 35, 105, 98, 104, 104, 37, 98, 35, 106, 98, 104, 104, 104, 37 }, 88), _0x409b2956, _0x4877737b, _0x3172122a);
    }

    private async Task<bool> _0x784b2494()
    {
        {
#if B_LOGS
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[37] { 96, 111, 94, 72, 79, 102, 27, 104, 82, 92, 85, 114, 85, 110, 85, 82, 79, 66, 104, 94, 73, 77, 82, 88, 94, 72, 122, 85, 84, 85, 66, 86, 84, 78, 72, 87, 66 }, 59));
#endif
        }

        try
        {
            var _0xb908f157 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xb908f157);
            {
#if B_LOGS
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[32] { 33, 46, 31, 9, 14, 39, 90, 47, 20, 19, 14, 3, 41, 31, 8, 12, 19, 25, 31, 9, 90, 51, 20, 19, 14, 19, 27, 22, 19, 0, 31, 30 }, 122));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[20] { 8, 25, 15, 8, 124, 9, 50, 53, 40, 37, 15, 57, 46, 42, 53, 63, 57, 47, 102, 124 }, 92) + ex.Message);
#endif
            }

            _0x74caa470?._0x82676525();
            return true;
        }

        bool _0x8ba0d5d4 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x8ba0d5d4 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0xaf8b4e93._0x72900d32(new byte[37] { 26, 21, 36, 50, 53, 28, 97, 18, 40, 38, 47, 108, 40, 47, 97, 0, 47, 46, 47, 56, 44, 46, 52, 50, 111, 97, 17, 45, 32, 56, 36, 51, 97, 8, 5, 123, 97 }, 65) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xea5f2227 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[25] { 204, 221, 203, 204, 184, 203, 241, 255, 246, 181, 241, 246, 184, 217, 237, 236, 240, 184, 221, 202, 202, 215, 202, 162, 184 }, 152) + ex.Message);
#endif
                }

                _0x74caa470?._0x82676525();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[28] { 85, 68, 82, 85, 33, 82, 104, 102, 111, 44, 104, 111, 33, 83, 100, 112, 116, 100, 114, 117, 33, 68, 83, 83, 78, 83, 59, 33 }, 1) + ex.Message);
#endif
                }

                _0x74caa470?._0x82676525();
                return true;
            }
        }
        while (!_0x8ba0d5d4);
        return false;
    }

    private void _0x2ce669f6(string _0xca0474e9)
    {
        if (string.IsNullOrEmpty(_0xca0474e9))
            return;
        if (TryOpenExternalLikeChrome(_0xca0474e9))
            return;
        OpenUrlExternally(_0xca0474e9);
    }

    private string _0x33c7c401 = "";
    internal void Update()
    {
        if (_0xb9cf1b48 == null)
            return;
        if (_0x89a1c8e2())
            _0x3b1b5007();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xe81247fa();
        if (_0x26a0300f && _0xd1b60873 != null)
            _0xd1b60873.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x230b4b8d = false;
    internal bool isApplicationPause = false;
    private IEnumerator _0x00688474()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[26] { 113, 126, 79, 89, 94, 119, 10, 99, 68, 67, 94, 67, 75, 70, 67, 80, 79, 120, 79, 76, 76, 79, 88, 79, 88, 10 }, 42));
            }
#endif
        }

        bool _0x082b86cc = false;
        InstallReferrer.GetReferrer((_0xe53d1ac0) =>
        {
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[24] { 90, 85, 100, 114, 117, 33, 83, 100, 103, 100, 115, 115, 100, 115, 92, 33, 102, 100, 117, 33, 227, 135, 147, 33 }, 1) + _0xb41150c2);
            if (_0xe53d1ac0.IsSuccess)
            {
                _0xb41150c2 = _0xe53d1ac0.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[28] { 84, 91, 106, 124, 123, 47, 93, 106, 105, 106, 125, 125, 106, 125, 82, 47, 92, 122, 108, 108, 106, 124, 124, 47, 237, 137, 157, 47 }, 15) + _0xb41150c2);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[27] { 163, 172, 157, 139, 140, 216, 170, 157, 158, 157, 138, 138, 157, 138, 165, 216, 190, 153, 145, 148, 157, 156, 216, 26, 126, 106, 216 }, 248) + _0xe53d1ac0);
#endif
                }

                _0xb41150c2 = "";
            }

            _0xa968ef14 = true;
        });
        StartCoroutine(_0xd7b9842c(2f));
        yield return new WaitUntil(() => _0xa968ef14);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xb41150c2}");
#endif
        }

        bool _0x8946c47d = _0xb41150c2.Contains(_0xaf8b4e93._0x72900d32(new byte[6] { 120, 124, 115, 118, 123, 34 }, 31));
        _0x082b86cc = _0x8946c47d || _0xb41150c2.Contains(_0xaf8b4e93._0x72900d32(new byte[18] { 88, 73, 73, 74, 23, 80, 87, 74, 77, 88, 94, 75, 88, 84, 23, 90, 86, 84 }, 57)) || _0xb41150c2.Contains(_0xaf8b4e93._0x72900d32(new byte[17] { 67, 82, 82, 81, 12, 68, 67, 65, 71, 64, 77, 77, 73, 12, 65, 77, 79 }, 34));
        _0xbd52f0c9 = _0x8946c47d ? "" : (_0x082b86cc ? "" : _0xbd52f0c9);
        _0xbd52f0c9 = _0xbd52f0c9 ?? "";
        _0xb2694447 = _0xb2694447 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xbd52f0c9}");
#endif
        }
    }

    private string _0x09fd9ce1 = "";
    private void WLog(string _0x961809b3)
    {
#if B_LOGS
        {
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[7] { 177, 190, 143, 153, 158, 183, 202 }, 234) + _0x961809b3);
        }
#endif
    }

    private string _0x13b19fcc = "";
    private bool _0xdb1ed7bb = false;
    private GameObject _0x4b416bb3;
    internal bool firstLoadShown = false;
    private Canvas _0x558cb387;
    private bool _0x89a1c8e2()
    {
        var _0x179ce43c = Keyboard.current;
        return _0x179ce43c != null && _0x179ce43c.escapeKey.wasPressedThisFrame;
    }

    private string _0x2a89b498 = "";
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0xbc3c4cbc)
    {
        if (Permission.HasUserAuthorizedPermission(_0xbc3c4cbc))
            yield break;
        bool _0x9dcc80a5 = false;
        var _0xbf718898 = new PermissionCallbacks();
        _0xbf718898.PermissionGranted += _0x12c3955a => _0x9dcc80a5 = true;
        _0xbf718898.PermissionDenied += _0x12c3955a => _0x9dcc80a5 = true;
        Permission.RequestUserPermission(_0xbc3c4cbc, _0xbf718898);
        yield return new WaitUntil(() => _0x9dcc80a5);
    }

    internal bool IsGoogleAuthFlowUrl(string _0xf9a5ca61)
    {
        if (string.IsNullOrEmpty(_0xf9a5ca61))
            return false;
        return _0xf9a5ca61.IndexOf(_0xaf8b4e93._0x72900d32(new byte[19] { 246, 244, 244, 248, 226, 249, 227, 228, 185, 240, 248, 248, 240, 251, 242, 185, 244, 248, 250 }, 151), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf9a5ca61.IndexOf(_0xaf8b4e93._0x72900d32(new byte[16] { 156, 158, 158, 146, 136, 147, 137, 142, 211, 154, 146, 146, 154, 145, 152, 211 }, 253), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf9a5ca61.IndexOf(_0xaf8b4e93._0x72900d32(new byte[21] { 81, 89, 89, 81, 90, 83, 67, 69, 83, 68, 85, 89, 88, 66, 83, 88, 66, 24, 85, 89, 91 }, 54), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf9a5ca61.IndexOf(_0xaf8b4e93._0x72900d32(new byte[11] { 181, 161, 166, 179, 166, 187, 177, 252, 177, 189, 191 }, 210), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x0db42542()
    {
        var _0x39d749f5 = _0xaf8b4e93._0x72900d32(new byte[40] { 211, 207, 207, 203, 200, 129, 148, 148, 204, 204, 204, 149, 216, 215, 212, 206, 223, 221, 215, 218, 201, 222, 149, 216, 212, 214, 148, 216, 223, 213, 150, 216, 220, 210, 148, 207, 201, 218, 216, 222 }, 187);
        using (UnityWebRequest _0x8b165a74 = UnityWebRequest.Get(_0x39d749f5))
        {
            await _0x8b165a74.SendWebRequest();
            string[] _0xe504a153 = _0x8b165a74.downloadHandler.text.Split('\n');
            foreach (string _0x34484b06 in _0xe504a153)
            {
                if (_0x34484b06.StartsWith(_0xaf8b4e93._0x72900d32(new byte[3] { 71, 94, 19 }, 46)))
                {
                    string _0xa69f4c48 = _0x34484b06.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xa69f4c48} from {_0x39d749f5}");
                        }
#endif
                    }

                    return _0xa69f4c48;
                }
            }
        }

        return "";
    }

    private async Task<bool> _0x922285f4()
    {
        _0x72c0b5aa.Instance?._0xacd5243b();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xa27d20c3) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[32] { 55, 56, 9, 31, 24, 49, 76, 57, 2, 5, 24, 21, 76, 60, 25, 31, 4, 76, 34, 3, 24, 5, 10, 5, 15, 13, 24, 5, 3, 2, 86, 76 }, 108) + string.Join(_0xaf8b4e93._0x72900d32(new byte[1] { 162 }, 171), _0xa27d20c3));
                }
#endif
            }
        };
        try
        {
            _0x258641f2 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[31] { 65, 78, 127, 105, 110, 71, 58, 92, 123, 115, 118, 127, 126, 58, 110, 117, 58, 125, 127, 110, 58, 106, 111, 105, 114, 58, 110, 117, 113, 127, 116 }, 26));
                }
#endif
            }

            _0x258641f2 = "";
        }

        _0x8a751ded = !string.IsNullOrEmpty(_0x258641f2);
        _0x26e57846 = _0x2e87b8dd();
        {
#if B_LOGS
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[25] { 229, 234, 219, 205, 202, 227, 158, 235, 208, 215, 202, 199, 158, 238, 203, 205, 214, 158, 234, 209, 213, 219, 208, 132, 158 }, 190) + _0x258641f2);
#endif
        }

        _0x72c0b5aa.Instance?._0x6b5dadb5();
        return false;
    }

    private UniWebViewPopup _0x1a46d765()
    {
        for (int _0x97fc6afd = _0x8d979722.Count - 1; _0x97fc6afd >= 0; _0x97fc6afd--)
        {
            var _0xfee40e59 = _0x8d979722[_0x97fc6afd];
            if (_0xfee40e59 != null && _0xfee40e59.IsAlive)
                return _0xfee40e59;
            _0x8d979722.RemoveAt(_0x97fc6afd);
        }

        return null;
    }

    private void _0x3b1b5007()
    {
        WLog(_0xaf8b4e93._0x72900d32(new byte[21] { 144, 185, 170, 188, 175, 185, 170, 189, 248, 186, 185, 187, 179, 248, 168, 170, 189, 171, 171, 189, 188 }, 216));
        if (Time.frameCount == _0x63e5c131)
            return;
        _0x63e5c131 = Time.frameCount;
        if (_0xd48b8975())
            return;
        _0x43440903();
    }

    private Text _0xee3bdb23;
    private string _0x1460526c = "";
    private bool _0x1a76f692(int _0x039efa3d, string _0x3ffe6322, string _0x9889a1ae)
    {
        if (string.IsNullOrEmpty(_0x9889a1ae))
            return false;
        if (!IsHttpUrl(_0x9889a1ae))
            return true;
        if (string.IsNullOrEmpty(_0x3ffe6322))
            return false;
        return _0x3ffe6322.IndexOf(_0xaf8b4e93._0x72900d32(new byte[20] { 27, 12, 12, 1, 29, 17, 16, 16, 27, 29, 10, 23, 17, 16, 1, 12, 27, 13, 27, 10 }, 94), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3ffe6322.IndexOf(_0xaf8b4e93._0x72900d32(new byte[22] { 200, 223, 223, 210, 206, 194, 195, 195, 200, 206, 217, 196, 194, 195, 210, 223, 200, 203, 216, 222, 200, 201 }, 141), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3ffe6322.IndexOf(_0xaf8b4e93._0x72900d32(new byte[21] { 209, 198, 198, 203, 215, 219, 218, 218, 209, 215, 192, 221, 219, 218, 203, 215, 216, 219, 199, 209, 208 }, 148), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3ffe6322.IndexOf(_0xaf8b4e93._0x72900d32(new byte[22] { 52, 35, 35, 46, 36, 63, 58, 63, 62, 38, 63, 46, 36, 35, 61, 46, 34, 50, 57, 52, 60, 52 }, 113), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private readonly List<UniWebViewPopup> _0x8d979722 = new List<UniWebViewPopup>();
    private string _0xb6937bfd = "";
    private int _0x93f1a96d = 0;
    private string _0x765abca1 = "";
    internal bool isDestroyedForce = false;
    private void _0x95f5ef92()
    {
        using (var _0xc53a8a7c = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[30] { 75, 71, 69, 6, 93, 70, 65, 92, 81, 27, 76, 6, 88, 68, 73, 81, 77, 90, 6, 125, 70, 65, 92, 81, 120, 68, 73, 81, 77, 90 }, 40)))
        using (var _0xd0255682 = _0xc53a8a7c.GetStatic<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[15] { 227, 245, 242, 242, 229, 238, 244, 193, 227, 244, 233, 246, 233, 244, 249 }, 128)))
        using (var _0x61ca57ee = _0xd0255682.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[9] { 80, 82, 67, 126, 89, 67, 82, 89, 67 }, 55)))
        {
            if (_0x61ca57ee == null)
                return;
            using (var _0x1b91f846 = _0x61ca57ee.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[9] { 176, 178, 163, 146, 175, 163, 165, 182, 164 }, 215)))
            {
                if (_0x1b91f846 == null)
                    return;
                using (var _0x047ecf23 = new AndroidJavaObject(_0xaf8b4e93._0x72900d32(new byte[19] { 148, 137, 156, 213, 145, 136, 148, 149, 213, 177, 168, 180, 181, 180, 153, 145, 158, 152, 143 }, 251)))
                using (var _0xba9dee3c = _0x1b91f846.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[6] { 155, 149, 137, 163, 149, 132 }, 240)))
                using (var _0x6786e96d = _0xba9dee3c.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[8] { 213, 200, 217, 206, 221, 200, 211, 206 }, 188)))
                {
                    while (_0x6786e96d.Call<bool>(_0xaf8b4e93._0x72900d32(new byte[7] { 36, 45, 63, 2, 41, 52, 56 }, 76)))
                    {
                        string _0x1f36b06f = _0x6786e96d.Call<string>(_0xaf8b4e93._0x72900d32(new byte[4] { 220, 215, 202, 198 }, 178));
                        using (var _0x55da84f0 = _0x1b91f846.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[3] { 159, 157, 140 }, 248), _0x1f36b06f))
                        {
                            _0x047ecf23.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[3] { 139, 142, 143 }, 251), _0x1f36b06f, _0x55da84f0);
                        }
                    }

                    string _0x8295789e = _0x047ecf23.Call<string>(_0xaf8b4e93._0x72900d32(new byte[8] { 222, 197, 249, 222, 216, 195, 196, 205 }, 170));
                    if (!string.IsNullOrEmpty(_0x8295789e))
                    {
                        _0x99bcd113(_0x8295789e);
                        _0xe21c5731(_0x8295789e);
                    }
                }
            }
        }
    }

    private void _0xa1e0801d()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0xda8ec167 = "";
    private void _0x0bda0138()
    {
        if (_0xb9cf1b48 == null)
            return;
        if (_0x230b4b8d)
            _0xb9cf1b48.SetUserAgent(_0x30e5eba5());
        else
            _0xb9cf1b48.SetUserAgent("");
    }

    private Action _0x13765ea0;
    private int _0x63e5c131 = -1;
    private bool _0xb79a1a54 = false;
    private string _0xea5f2227 = "";
    internal string _0x28106d73(string _0x791473ae)
    {
        int _0x1c942ca2 = _0x791473ae.IndexOf(_0xaf8b4e93._0x72900d32(new byte[3] { 2, 15, 86 }, 107), StringComparison.OrdinalIgnoreCase);
        if (_0x1c942ca2 < 0)
            return null;
        string _0x14aa193e = _0x791473ae.Substring(_0x1c942ca2 + 3);
        int _0x3cad3939 = _0x14aa193e.IndexOf('&');
        return _0x3cad3939 >= 0 ? _0x14aa193e.Substring(0, _0x3cad3939) : _0x14aa193e;
    }

    private bool _0xcd7845e2 = false;
    internal bool ContainsIgnoreCase(string _0xd6e2305d, string _0x1b43eaff)
    {
        if (string.IsNullOrEmpty(_0xd6e2305d) || string.IsNullOrEmpty(_0x1b43eaff))
            return false;
        return _0xd6e2305d.IndexOf(_0x1b43eaff, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private static readonly string WindowsDesktopUserAgent = _0xaf8b4e93._0x72900d32(new byte[111] { 110, 76, 89, 74, 79, 79, 66, 12, 22, 13, 19, 3, 11, 116, 74, 77, 71, 76, 84, 80, 3, 109, 119, 3, 18, 19, 13, 19, 24, 3, 116, 74, 77, 21, 23, 24, 3, 91, 21, 23, 10, 3, 98, 83, 83, 79, 70, 116, 70, 65, 104, 74, 87, 12, 22, 16, 20, 13, 16, 21, 3, 11, 104, 107, 119, 110, 111, 15, 3, 79, 74, 72, 70, 3, 100, 70, 64, 72, 76, 10, 3, 96, 75, 81, 76, 78, 70, 12, 18, 17, 19, 13, 19, 13, 19, 13, 19, 3, 112, 66, 69, 66, 81, 74, 12, 22, 16, 20, 13, 16, 21 }, 35);
    private bool _0xef2d3a51()
    {
        var _0x147a186e = _0x1a46d765();
        if (_0x147a186e == null)
            return false;
        WLog(_0xaf8b4e93._0x72900d32(new byte[31] { 236, 197, 214, 192, 211, 197, 214, 193, 132, 198, 197, 199, 207, 132, 137, 154, 132, 212, 203, 212, 209, 212, 132, 227, 203, 230, 197, 199, 207, 158, 132 }, 164) + _0x147a186e.Id);
        _0x147a186e.GoBack();
        return true;
    }

    private string _0xd2cea0f6 = "";
    private async Task<bool> _0x76552dc8()
    {
        {
#if B_LOGS
            Debug.Log(_0xaf8b4e93._0x72900d32(new byte[29] { 204, 195, 242, 228, 227, 202, 183, 222, 228, 199, 229, 254, 225, 246, 244, 238, 214, 249, 243, 196, 246, 225, 242, 243, 212, 255, 242, 244, 252 }, 151));
#endif
        }

        string _0xb06df88f = "";
        for (int _0x0ff4be56 = 0; _0x0ff4be56 < 2; _0x0ff4be56++)
        {
            if (await _0x937c62c3(1, 100))
            {
                await _0x8e8359e4(_0xaf8b4e93._0x72900d32(new byte[7] { 55, 57, 58, 54, 62, 48, 49 }, 85));
                _0x82676525();
                return true;
            }

            _0xb06df88f = await _0xe42183ec(1, 100);
            if (!string.IsNullOrEmpty(_0xb06df88f))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xb06df88f))
            {
                if (!string.IsNullOrEmpty(_0xbab5d9f4))
                {
                    _0xb06df88f = _0xf384ee15(_0xb06df88f, _0xbab5d9f4);
                    {
#if B_LOGS
                        Debug.Log(_0xaf8b4e93._0x72900d32(new byte[53] { 48, 63, 14, 24, 31, 54, 75, 40, 10, 8, 3, 14, 15, 75, 13, 2, 5, 10, 7, 62, 25, 7, 75, 28, 2, 31, 3, 75, 24, 14, 5, 15, 2, 15, 75, 137, 237, 249, 75, 24, 3, 4, 28, 75, 60, 14, 9, 61, 2, 14, 28, 81, 75 }, 107) + _0xb06df88f);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0xaf8b4e93._0x72900d32(new byte[39] { 249, 246, 199, 209, 214, 255, 130, 225, 195, 193, 202, 199, 198, 130, 196, 203, 204, 195, 206, 247, 208, 206, 130, 64, 36, 48, 130, 209, 202, 205, 213, 130, 245, 199, 192, 244, 203, 199, 213 }, 162));
#endif
                    }
                }

                _0xdb1ed7bb = true;
                _0x0d050454(_0xb06df88f);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xaf8b4e93._0x72900d32(new byte[44] { 15, 0, 49, 39, 32, 9, 116, 17, 44, 55, 49, 36, 32, 61, 59, 58, 116, 35, 60, 61, 56, 49, 116, 55, 60, 49, 55, 63, 61, 58, 51, 116, 39, 53, 34, 49, 48, 116, 56, 61, 58, 63, 110, 116 }, 84) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private RectTransform _0xd1b60873;
    internal Vector2 lastSize = Vector2.zero;
    private void _0x99bcd113(string _0x71bf4ccc)
    {
        Dictionary<string, object> _0x49c9b06f;
        try
        {
            _0x49c9b06f = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x71bf4ccc);
        }
        catch
        {
            return;
        }

        var _0x367740d2 = ReadPushField(_0x49c9b06f, _0xaf8b4e93._0x72900d32(new byte[3] { 54, 49, 47 }, 67));
        if (string.IsNullOrWhiteSpace(_0x367740d2))
            return;
        _0x367740d2 = _0x367740d2.Trim();
        if (!IsHttpUrl(_0x367740d2))
            return;
        if (string.Equals(_0x367740d2, _0xc0ea3911, StringComparison.Ordinal))
            return;
        _0xc0ea3911 = _0x367740d2;
        OpenUrlExternally(_0x367740d2);
    }

    private string _0x7e3a4d1f = "";
    private async void Start()
    {
        await _0x49ce569f();
    }

    private string _0x258641f2 = "";
    private void _0x62d9f5b7(bool _0x4c193ff7)
    {
        _0x7ba7ca50();
        _0x4b416bb3.SetActive(_0x4c193ff7);
        _0x26a0300f = _0x4c193ff7;
        if (_0x4c193ff7)
        {
            _0x4b416bb3.transform.SetAsLastSibling();
            if (_0xd1b60873 != null)
                _0xd1b60873.localRotation = Quaternion.identity;
        }
    }

    private string _0x9496e28d = "";
    private async Task _0x9797080d()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x9496e28d = _0xaf8b4e93._0x72900d32(new byte[5] { 7, 0, 13, 18, 4 }, 97);
        _0x33c7c401 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x09fd9ce1 = DateTime.UtcNow.Ticks.ToString();
        _0xd3efdf96 = "";
        JObject _0x94d4618c = BuildRandomPayload(_0x2a89b498, _0x77d9683f, _0xb6937bfd, _0x258641f2, _0xb41150c2, _0xbd52f0c9, _0xb2694447, _0x7e3a4d1f, _0x7e2d13fa, _0xd2cea0f6, _0x9496e28d, _0xd3efdf96, _0x5f74ad2f, _0x13b19fcc, _0x3f53f4e8.ToString(), _0x1460526c, _0x09fd9ce1, _0x33c7c401, _0xea5f2227, _0x765abca1, _0xd6f64365, _0x26e57846, _0x2e87b8dd());
        var _0xb2e5331b = _0xa8a557ed(_0x94d4618c.ToString(), _0xea5f2227);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x94d4618c}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xaf8b4e93._0x72900d32(new byte[7] { 196, 213, 205, 216, 219, 213, 208 }, 180) + _0xea5f2227, _0xb2e5331b } });
            await Task.Delay(500);
            string _0x3bd0b9bd = "";
            for (int _0x00a3b0a7 = 0; _0x00a3b0a7 < 20; _0x00a3b0a7++)
            {
                if (await _0x937c62c3(1, 1))
                {
                    await _0x8e8359e4(_0xaf8b4e93._0x72900d32(new byte[7] { 112, 126, 125, 113, 121, 119, 118 }, 18));
                    _0x82676525();
                    return;
                }

                _0x3bd0b9bd = await _0xe42183ec(1, 500);
                if (!string.IsNullOrEmpty(_0x3bd0b9bd))
                    break;
            }

            _0x207f57f4(_0x3bd0b9bd);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[22] { 61, 50, 35, 53, 50, 59, 70, 33, 3, 8, 3, 20, 7, 10, 70, 3, 20, 20, 9, 20, 92, 70 }, 102) + e.Message);
#endif
            }

            _0x82676525();
        }
    }

    private void _0x207f57f4(string _0x837f4ad3)
    {
        bool _0xb5eec4e8 = !string.IsNullOrEmpty(_0x837f4ad3);
        if (_0xb5eec4e8)
        {
            {
#if B_LOGS
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[13] { 176, 191, 142, 152, 159, 182, 203, 184, 131, 132, 156, 209, 203 }, 235) + _0x837f4ad3);
#endif
            }

            _0x0d050454(_0x837f4ad3);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[39] { 212, 219, 234, 252, 251, 210, 175, 201, 238, 227, 227, 237, 238, 236, 228, 175, 109, 9, 29, 175, 200, 238, 226, 234, 175, 167, 225, 224, 175, 233, 230, 225, 238, 227, 175, 218, 221, 195, 166 }, 143));
#endif
            }

            _0x82676525();
            return;
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0xa7dd5a3e)
    {
        _0x62d9f5b7(false);
        if (_0xa7dd5a3e == null)
            return;
        _0xa7dd5a3e.Stop();
        if (_0xa7dd5a3e.CanGoBack)
            _0xa7dd5a3e.GoBack();
    }

    private int _0x79e8363a = 5, _0x77a302a3 = 5, _0x9ab4b28f = 5, _0x93d3fcf0 = 5;
    // WS_SOURCE MONO
    public static _0x9018c538 _0x74caa470 { get; private set; }

    private string _0x5f74ad2f = "";
    private bool OpenUrlExternally(string _0xa9d5b310)
    {
        return _0x8c2056f8(_0xa9d5b310);
    }

    private string _0xbab5d9f4;
    private bool _0x8546680c = false;
    private string _0x30e5eba5()
    {
        if (string.IsNullOrEmpty(_0x7e3a4d1f) && _0xb9cf1b48 != null)
            _0x7e3a4d1f = _0xb9cf1b48.GetUserAgent();
        if (string.IsNullOrEmpty(_0x7e3a4d1f))
            return string.Empty;
        string _0x69bc4157 = Regex.Replace(_0x7e3a4d1f, _0xaf8b4e93._0x72900d32(new byte[11] { 61, 18, 75, 90, 61, 18, 75, 22, 23, 61, 3 }, 97), string.Empty);
        _0x69bc4157 = Regex.Replace(_0x69bc4157, _0xaf8b4e93._0x72900d32(new byte[15] { 192, 239, 183, 222, 233, 245, 240, 248, 179, 199, 194, 167, 181, 193, 183 }, 156), string.Empty);
        _0x69bc4157 = Regex.Replace(_0x69bc4157, _0xaf8b4e93._0x72900d32(new byte[15] { 62, 13, 26, 27, 1, 7, 6, 71, 92, 52, 70, 88, 52, 27, 66 }, 104), string.Empty);
        return Regex.Replace(_0x69bc4157, _0xaf8b4e93._0x72900d32(new byte[6] { 103, 72, 64, 9, 23, 70 }, 59), _0xaf8b4e93._0x72900d32(new byte[1] { 83 }, 115)).Trim();
    }

    private string Decrypt(string _0x329a22c7, string _0xa50a4658)
    {
        try
        {
            var _0x4032beab = Convert.FromBase64String(_0x329a22c7);
            using var _0xbc41e93a = Aes.Create();
            _0xbc41e93a.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xa50a4658));
            var _0xcbed5818 = new byte[16];
            Buffer.BlockCopy(_0x4032beab, 0, _0xcbed5818, 0, 16);
            _0xbc41e93a.IV = _0xcbed5818;
            using var _0x08b6d31d = new MemoryStream(_0x4032beab, 16, _0x4032beab.Length - 16);
            using var _0x96873eb0 = new CryptoStream(_0x08b6d31d, _0xbc41e93a.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x278f754a = new StreamReader(_0x96873eb0, Encoding.UTF8);
            return _0x278f754a.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal bool IsAboutBlank(string _0xd62e871b)
    {
        if (string.IsNullOrEmpty(_0xd62e871b))
            return false;
        return _0xd62e871b.StartsWith(_0xaf8b4e93._0x72900d32(new byte[11] { 245, 246, 251, 225, 224, 174, 246, 248, 245, 250, 255 }, 148), StringComparison.OrdinalIgnoreCase);
    }

    internal Rect lastSafe = Rect.zero;
    private static string ReadPushField(Dictionary<string, object> _0x810d3c02, string _0xb9503997)
    {
        if (_0x810d3c02 == null || string.IsNullOrEmpty(_0xb9503997))
            return string.Empty;
        if (_0x810d3c02.TryGetValue(_0xaf8b4e93._0x72900d32(new byte[16] { 225, 224, 251, 230, 233, 230, 236, 238, 251, 230, 224, 225, 203, 238, 251, 238 }, 143), out var raw))
        {
            try
            {
                var _0x0443de12 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x0443de12 != null && _0x0443de12.TryGetValue(_0xb9503997, out var nestedVal))
                {
                    var _0xe6213480 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xe6213480))
                        return _0xe6213480;
                }
            }
            catch
            {
            }
        }

        if (_0x810d3c02.TryGetValue(_0xb9503997, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private string _0xd3efdf96 = "";
    private string _0xfbdb8d4b()
    {
        return _0xaf8b4e93._0x72900d32(new byte[12] { 205, 131, 144, 139, 134, 145, 140, 138, 139, 205, 204, 158 }, 229) + _0xaf8b4e93._0x72900d32(new byte[8] { 14, 25, 10, 88, 13, 25, 69, 95 }, 120) + WindowsDesktopUserAgent + _0xaf8b4e93._0x72900d32(new byte[2] { 192, 220 }, 231) + _0xaf8b4e93._0x72900d32(new byte[30] { 23, 0, 19, 65, 17, 19, 14, 21, 14, 92, 47, 0, 23, 8, 6, 0, 21, 14, 19, 79, 17, 19, 14, 21, 14, 21, 24, 17, 4, 90 }, 97) + _0xaf8b4e93._0x72900d32(new byte[121] { 67, 80, 75, 70, 81, 76, 74, 75, 5, 65, 64, 67, 13, 74, 71, 79, 9, 78, 64, 92, 9, 83, 68, 73, 12, 94, 81, 87, 92, 94, 106, 71, 79, 64, 70, 81, 11, 65, 64, 67, 76, 75, 64, 117, 87, 74, 85, 64, 87, 81, 92, 13, 74, 71, 79, 9, 78, 64, 92, 9, 94, 66, 64, 81, 31, 67, 80, 75, 70, 81, 76, 74, 75, 13, 12, 94, 87, 64, 81, 80, 87, 75, 5, 83, 68, 73, 30, 88, 9, 70, 74, 75, 67, 76, 66, 80, 87, 68, 71, 73, 64, 31, 81, 87, 80, 64, 88, 12, 30, 88, 70, 68, 81, 70, 77, 13, 64, 12, 94, 88, 88 }, 37) + _0xaf8b4e93._0x72900d32(new byte[26] { 157, 156, 159, 209, 137, 139, 150, 141, 150, 213, 222, 140, 138, 156, 139, 184, 158, 156, 151, 141, 222, 213, 140, 152, 208, 194 }, 249) + _0xaf8b4e93._0x72900d32(new byte[130] { 190, 191, 188, 242, 170, 168, 181, 174, 181, 246, 253, 187, 170, 170, 140, 191, 168, 169, 179, 181, 180, 253, 246, 253, 239, 244, 234, 250, 242, 141, 179, 180, 190, 181, 173, 169, 250, 148, 142, 250, 235, 234, 244, 234, 225, 250, 141, 179, 180, 236, 238, 225, 250, 162, 236, 238, 243, 250, 155, 170, 170, 182, 191, 141, 191, 184, 145, 179, 174, 245, 239, 233, 237, 244, 233, 236, 250, 242, 145, 146, 142, 151, 150, 246, 250, 182, 179, 177, 191, 250, 157, 191, 185, 177, 181, 243, 250, 153, 178, 168, 181, 183, 191, 245, 235, 232, 234, 244, 234, 244, 234, 244, 234, 250, 137, 187, 188, 187, 168, 179, 245, 239, 233, 237, 244, 233, 236, 253, 243, 225 }, 218) + _0xaf8b4e93._0x72900d32(new byte[30] { 214, 215, 212, 154, 194, 192, 221, 198, 221, 158, 149, 194, 222, 211, 198, 212, 221, 192, 223, 149, 158, 149, 229, 219, 220, 129, 128, 149, 155, 137 }, 178) + _0xaf8b4e93._0x72900d32(new byte[34] { 230, 231, 228, 170, 242, 240, 237, 246, 237, 174, 165, 244, 231, 236, 230, 237, 240, 165, 174, 165, 197, 237, 237, 229, 238, 231, 162, 203, 236, 225, 172, 165, 171, 185 }, 130) + _0xaf8b4e93._0x72900d32(new byte[30] { 189, 188, 191, 241, 169, 171, 182, 173, 182, 245, 254, 180, 184, 161, 141, 182, 172, 186, 177, 137, 182, 176, 183, 173, 170, 254, 245, 233, 240, 226 }, 217) + _0xaf8b4e93._0x72900d32(new byte[449] { 202, 204, 199, 197, 200, 223, 204, 158, 203, 223, 218, 131, 197, 220, 204, 223, 208, 218, 205, 132, 229, 197, 220, 204, 223, 208, 218, 132, 153, 253, 214, 204, 209, 211, 215, 203, 211, 153, 146, 200, 219, 204, 205, 215, 209, 208, 132, 153, 143, 140, 142, 153, 195, 146, 197, 220, 204, 223, 208, 218, 132, 153, 249, 209, 209, 217, 210, 219, 158, 253, 214, 204, 209, 211, 219, 153, 146, 200, 219, 204, 205, 215, 209, 208, 132, 153, 143, 140, 142, 153, 195, 146, 197, 220, 204, 223, 208, 218, 132, 153, 240, 209, 202, 131, 255, 129, 252, 204, 223, 208, 218, 153, 146, 200, 219, 204, 205, 215, 209, 208, 132, 153, 140, 138, 153, 195, 227, 146, 211, 209, 220, 215, 210, 219, 132, 216, 223, 210, 205, 219, 146, 206, 210, 223, 202, 216, 209, 204, 211, 132, 153, 233, 215, 208, 218, 209, 201, 205, 153, 146, 217, 219, 202, 246, 215, 217, 214, 251, 208, 202, 204, 209, 206, 199, 232, 223, 210, 203, 219, 205, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 204, 219, 202, 203, 204, 208, 158, 238, 204, 209, 211, 215, 205, 219, 144, 204, 219, 205, 209, 210, 200, 219, 150, 197, 223, 204, 221, 214, 215, 202, 219, 221, 202, 203, 204, 219, 132, 153, 198, 134, 136, 153, 146, 220, 215, 202, 208, 219, 205, 205, 132, 153, 136, 138, 153, 146, 211, 209, 220, 215, 210, 219, 132, 216, 223, 210, 205, 219, 146, 211, 209, 218, 219, 210, 132, 153, 153, 146, 206, 210, 223, 202, 216, 209, 204, 211, 132, 153, 233, 215, 208, 218, 209, 201, 205, 153, 146, 206, 210, 223, 202, 216, 209, 204, 211, 232, 219, 204, 205, 215, 209, 208, 132, 153, 143, 139, 144, 142, 144, 142, 153, 146, 203, 223, 248, 203, 210, 210, 232, 219, 204, 205, 215, 209, 208, 132, 153, 143, 140, 142, 144, 142, 144, 142, 144, 142, 153, 195, 151, 133, 195, 195, 133, 241, 220, 212, 219, 221, 202, 144, 218, 219, 216, 215, 208, 219, 238, 204, 209, 206, 219, 204, 202, 199, 150, 206, 204, 209, 202, 209, 146, 153, 203, 205, 219, 204, 255, 217, 219, 208, 202, 250, 223, 202, 223, 153, 146, 197, 217, 219, 202, 132, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197, 204, 219, 202, 203, 204, 208, 158, 203, 223, 218, 133, 195, 146, 221, 209, 208, 216, 215, 217, 203, 204, 223, 220, 210, 219, 132, 202, 204, 203, 219, 195, 151, 133, 195, 221, 223, 202, 221, 214, 150, 219, 151, 197, 195 }, 190) + _0xaf8b4e93._0x72900d32(new byte[112] { 230, 231, 228, 170, 241, 225, 240, 231, 231, 236, 174, 165, 245, 235, 230, 246, 234, 165, 174, 179, 187, 176, 178, 171, 185, 230, 231, 228, 170, 241, 225, 240, 231, 231, 236, 174, 165, 234, 231, 235, 229, 234, 246, 165, 174, 179, 178, 186, 178, 171, 185, 230, 231, 228, 170, 241, 225, 240, 231, 231, 236, 174, 165, 227, 244, 227, 235, 238, 213, 235, 230, 246, 234, 165, 174, 179, 187, 176, 178, 171, 185, 230, 231, 228, 170, 241, 225, 240, 231, 231, 236, 174, 165, 227, 244, 227, 235, 238, 202, 231, 235, 229, 234, 246, 165, 174, 179, 178, 182, 178, 171, 185 }, 130) + _0xaf8b4e93._0x72900d32(new byte[45] { 117, 115, 120, 122, 118, 104, 111, 101, 110, 118, 47, 110, 111, 117, 110, 116, 98, 105, 114, 117, 96, 115, 117, 60, 116, 111, 101, 100, 103, 104, 111, 100, 101, 58, 124, 98, 96, 117, 98, 105, 41, 100, 40, 122, 124 }, 1) + _0xaf8b4e93._0x72900d32(new byte[721] { 253, 251, 240, 242, 255, 232, 251, 169, 230, 251, 224, 238, 180, 254, 224, 231, 237, 230, 254, 167, 228, 232, 253, 234, 225, 196, 236, 237, 224, 232, 167, 235, 224, 231, 237, 161, 254, 224, 231, 237, 230, 254, 160, 178, 254, 224, 231, 237, 230, 254, 167, 228, 232, 253, 234, 225, 196, 236, 237, 224, 232, 180, 239, 252, 231, 234, 253, 224, 230, 231, 161, 248, 160, 242, 255, 232, 251, 169, 250, 180, 218, 253, 251, 224, 231, 238, 161, 248, 160, 167, 253, 230, 197, 230, 254, 236, 251, 202, 232, 250, 236, 161, 160, 178, 224, 239, 161, 250, 167, 224, 231, 237, 236, 241, 198, 239, 161, 174, 249, 230, 224, 231, 253, 236, 251, 179, 169, 234, 230, 232, 251, 250, 236, 174, 160, 183, 180, 185, 245, 245, 250, 167, 224, 231, 237, 236, 241, 198, 239, 161, 174, 225, 230, 255, 236, 251, 179, 169, 231, 230, 231, 236, 174, 160, 183, 180, 185, 245, 245, 250, 167, 224, 231, 237, 236, 241, 198, 239, 161, 174, 228, 232, 241, 164, 254, 224, 237, 253, 225, 174, 160, 183, 180, 185, 245, 245, 250, 167, 224, 231, 237, 236, 241, 198, 239, 161, 174, 228, 232, 241, 164, 237, 236, 255, 224, 234, 236, 164, 254, 224, 237, 253, 225, 174, 160, 183, 180, 185, 160, 251, 236, 253, 252, 251, 231, 169, 242, 228, 232, 253, 234, 225, 236, 250, 179, 239, 232, 229, 250, 236, 165, 228, 236, 237, 224, 232, 179, 248, 165, 230, 231, 234, 225, 232, 231, 238, 236, 179, 231, 252, 229, 229, 165, 232, 237, 237, 197, 224, 250, 253, 236, 231, 236, 251, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 244, 165, 251, 236, 228, 230, 255, 236, 197, 224, 250, 253, 236, 231, 236, 251, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 244, 165, 232, 237, 237, 204, 255, 236, 231, 253, 197, 224, 250, 253, 236, 231, 236, 251, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 244, 165, 251, 236, 228, 230, 255, 236, 204, 255, 236, 231, 253, 197, 224, 250, 253, 236, 231, 236, 251, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 244, 165, 237, 224, 250, 249, 232, 253, 234, 225, 204, 255, 236, 231, 253, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 251, 236, 253, 252, 251, 231, 169, 239, 232, 229, 250, 236, 178, 244, 244, 178, 224, 239, 161, 250, 167, 224, 231, 237, 236, 241, 198, 239, 161, 174, 249, 230, 224, 231, 253, 236, 251, 179, 169, 239, 224, 231, 236, 174, 160, 183, 180, 185, 245, 245, 250, 167, 224, 231, 237, 236, 241, 198, 239, 161, 174, 225, 230, 255, 236, 251, 179, 169, 225, 230, 255, 236, 251, 174, 160, 183, 180, 185, 160, 251, 236, 253, 252, 251, 231, 169, 242, 228, 232, 253, 234, 225, 236, 250, 179, 253, 251, 252, 236, 165, 228, 236, 237, 224, 232, 179, 248, 165, 230, 231, 234, 225, 232, 231, 238, 236, 179, 231, 252, 229, 229, 165, 232, 237, 237, 197, 224, 250, 253, 236, 231, 236, 251, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 244, 165, 251, 236, 228, 230, 255, 236, 197, 224, 250, 253, 236, 231, 236, 251, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 244, 165, 232, 237, 237, 204, 255, 236, 231, 253, 197, 224, 250, 253, 236, 231, 236, 251, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 244, 165, 251, 236, 228, 230, 255, 236, 204, 255, 236, 231, 253, 197, 224, 250, 253, 236, 231, 236, 251, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 244, 165, 237, 224, 250, 249, 232, 253, 234, 225, 204, 255, 236, 231, 253, 179, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242, 251, 236, 253, 252, 251, 231, 169, 239, 232, 229, 250, 236, 178, 244, 244, 178, 251, 236, 253, 252, 251, 231, 169, 230, 251, 224, 238, 161, 248, 160, 178, 244, 178, 244, 234, 232, 253, 234, 225, 161, 236, 160, 242, 244 }, 137) + _0xaf8b4e93._0x72900d32(new byte[5] { 9, 93, 92, 93, 79 }, 116);
    }

    private async Task<bool> _0x937c62c3(int _0x913ab1ef = 5, int _0xdff74a1f = 500)
    {
        List<EntityData> _0xd098ab15 = new List<EntityData>();
        int _0xbdbf99f5 = 0;
        do
        {
            try
            {
                _0xd098ab15 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xaf8b4e93._0x72900d32(new byte[8] { 87, 75, 70, 94, 66, 85, 110, 67 }, 39), _0xea5f2227, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xaf8b4e93._0x72900d32(new byte[9] { 234, 240, 211, 241, 234, 245, 226, 224, 250 }, 131) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xaf8b4e93._0x72900d32(new byte[32] { 170, 165, 148, 130, 133, 172, 209, 128, 132, 148, 131, 136, 176, 130, 136, 159, 146, 163, 148, 130, 132, 157, 133, 130, 209, 148, 131, 131, 158, 131, 203, 209 }, 241) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xdff74a1f);
        }
        while (_0xd098ab15.Count == 0 && _0xbdbf99f5++ < _0x913ab1ef);
        {
#if B_LOGS
            {
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[32] { 178, 189, 140, 154, 157, 180, 201, 160, 154, 185, 155, 128, 159, 136, 138, 144, 201, 184, 156, 140, 155, 144, 201, 155, 140, 154, 156, 133, 157, 154, 211, 201 }, 233) + JsonConvert.SerializeObject(_0xd098ab15, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[38] { 26, 21, 36, 50, 53, 28, 97, 8, 50, 17, 51, 40, 55, 32, 34, 56, 97, 16, 52, 36, 51, 56, 97, 51, 36, 50, 52, 45, 53, 50, 97, 34, 46, 52, 47, 53, 123, 97 }, 65) + _0xd098ab15.Count);
            }
#endif
        }

        bool _0x29da1bd0 = true;
        if (_0xd098ab15.Count == 0)
        {
            _0x29da1bd0 = false;
        }
        else
        {
            _0x29da1bd0 = _0xd098ab15.Any(_0xbe000e98 => _0xbe000e98.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[25] { 116, 123, 74, 92, 91, 114, 15, 102, 92, 127, 93, 70, 89, 78, 76, 86, 15, 93, 74, 92, 90, 67, 91, 21, 15 }, 47) + _0x29da1bd0);
            }
#endif
        }

        return _0x29da1bd0;
    }

    internal bool isApplicationFocus = false;
    private bool _0x8c978ee5()
    {
        _0x8d979722.RemoveAll(_0x1c3f763b => _0x1c3f763b == null || !_0x1c3f763b.IsAlive);
        return _0x8d979722.Count > 0;
    }

    private string _0x7e2d13fa = "";
    private void _0x7ba7ca50()
    {
        if (_0x4b416bb3 != null)
            return;
        var _0xf21b0476 = _0xe23d9c23();
        _0x4b416bb3 = new GameObject(_0xaf8b4e93._0x72900d32(new byte[14] { 146, 160, 167, 147, 172, 160, 178, 150, 181, 172, 171, 171, 160, 183 }, 197), typeof(RectTransform), typeof(Text));
        _0xd1b60873 = _0x4b416bb3.GetComponent<RectTransform>();
        _0xd1b60873.SetParent(_0xf21b0476.transform, false);
        _0xd1b60873.anchorMin = new Vector2(0.5f, 0.5f);
        _0xd1b60873.anchorMax = new Vector2(0.5f, 0.5f);
        _0xd1b60873.pivot = new Vector2(0.5f, 0.5f);
        _0xd1b60873.sizeDelta = new Vector2(600f, 600f);
        _0xd1b60873.anchoredPosition = Vector2.zero;
        _0xee3bdb23 = _0x4b416bb3.GetComponent<Text>();
        _0xee3bdb23.text = _0xaf8b4e93._0x72900d32(new byte[1] { 228 }, 203);
        _0xee3bdb23.font = Resources.GetBuiltinResource<Font>(_0xaf8b4e93._0x72900d32(new byte[17] { 105, 64, 66, 68, 70, 92, 119, 80, 75, 81, 76, 72, 64, 11, 81, 81, 67 }, 37));
        _0xee3bdb23.fontSize = 200;
        _0xee3bdb23.alignment = TextAnchor.MiddleCenter;
        _0xee3bdb23.color = Color.white;
        _0xee3bdb23.raycastTarget = false;
        _0x4b416bb3.SetActive(false);
    }

    private IEnumerator _0x98a74881(Dictionary<string, object> _0xadeb27b2)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[30] { 42, 37, 20, 2, 5, 44, 81, 55, 20, 5, 18, 25, 81, 52, 9, 5, 3, 16, 81, 33, 4, 2, 25, 81, 53, 16, 5, 16, 75, 81 }, 113) + string.Join(_0xaf8b4e93._0x72900d32(new byte[1] { 25 }, 16), _0xadeb27b2));
#endif
            }
        }

        string _0xbc94ff67 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xadeb27b2 != null && _0xadeb27b2.TryGetValue(_0xaf8b4e93._0x72900d32(new byte[16] { 12, 13, 22, 11, 4, 11, 1, 3, 22, 11, 13, 12, 38, 3, 22, 3 }, 98), out var raw))
        {
            try
            {
                var _0xa844e931 = raw?.ToString();
                var _0xd6e77674 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xa844e931);
                if (_0xd6e77674 != null && _0xd6e77674.TryGetValue(_0xaf8b4e93._0x72900d32(new byte[6] { 47, 57, 50, 56, 53, 56 }, 92), out var val))
                {
                    _0xbc94ff67 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0xaf8b4e93._0x72900d32(new byte[30] { 245, 250, 203, 221, 218, 142, 254, 219, 221, 198, 243, 142, 228, 253, 225, 224, 142, 222, 207, 220, 221, 203, 142, 203, 220, 220, 193, 220, 148, 142 }, 174) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xbc94ff67) && _0xadeb27b2 != null && _0xadeb27b2.TryGetValue(_0xaf8b4e93._0x72900d32(new byte[6] { 56, 46, 37, 47, 34, 47 }, 75), out var lab))
        {
            _0xbc94ff67 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[38] { 230, 233, 216, 206, 201, 157, 237, 200, 206, 213, 224, 157, 251, 216, 201, 222, 213, 216, 217, 157, 206, 216, 211, 217, 212, 217, 157, 219, 207, 210, 208, 157, 215, 206, 210, 211, 135, 157 }, 189) + _0xbc94ff67);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xbc94ff67))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[38] { 210, 221, 236, 250, 253, 169, 217, 252, 250, 225, 212, 169, 222, 232, 224, 253, 169, 253, 230, 169, 230, 249, 236, 231, 169, 254, 224, 253, 225, 169, 250, 236, 231, 237, 224, 237, 179, 169 }, 137) + _0xbc94ff67);
            }
#endif
        }

        _0xbab5d9f4 = _0xbc94ff67;
        yield return new WaitUntil(() => _0x64ddcf13);
        var _0x50b0c4a9 = _0xe42183ec(2, 100);
        yield return new WaitUntil(() => _0x50b0c4a9.IsCompleted);
        string _0x788453f3 = _0x50b0c4a9.Result;
        if (!string.IsNullOrEmpty(_0x788453f3))
        {
            string _0xbe65eeeb = _0xf384ee15(_0x788453f3, _0xbc94ff67);
            {
#if B_LOGS
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[33] { 77, 66, 115, 101, 98, 54, 70, 99, 101, 126, 75, 54, 68, 115, 122, 121, 119, 114, 54, 65, 115, 116, 64, 127, 115, 97, 54, 97, 127, 98, 126, 44, 54 }, 22) + _0xbe65eeeb);
#endif
            }

            _0xb9cf1b48.Load(_0xbe65eeeb);
        }
    }

    private IEnumerator _0x5568b2aa(IEnumerator _0xa1b6e3df, TaskCompletionSource<bool> _0x2d1d331a)
    {
        yield return _0xa1b6e3df;
        _0x2d1d331a.SetResult(true);
    }

    internal void _0xe81247fa()
    {
        Rect _0x9a2967f4 = Screen.safeArea;
        Vector2 _0xa45213ee = new Vector2(Screen.width, Screen.height);
        if (_0x9a2967f4 == lastSafe && _0xa45213ee == lastSize)
            return;
        // Apply manual padding
        _0x9a2967f4.xMin += _0x9ab4b28f;
        _0x9a2967f4.xMax -= _0x93d3fcf0;
        _0x9a2967f4.yMin += _0x77a302a3;
        _0x9a2967f4.yMax -= _0x79e8363a;
        // Convert Unity safe area -> native WebView frame
        Rect _0xe55ba1ed = new Rect(_0x9a2967f4.x, _0xa45213ee.y - _0x9a2967f4.y - _0x9a2967f4.height, // Y flip for native coordinate system
 _0x9a2967f4.width, _0x9a2967f4.height);
        _0xb9cf1b48.Frame = _0xe55ba1ed;
        lastSafe = Screen.safeArea;
        lastSize = _0xa45213ee;
    }

    private bool _0x298f40e6(string _0x0c2927bb, string _0xd794be39)
    {
        string _0x89e89097 = _0x28106d73(_0x0c2927bb);
        if (string.IsNullOrEmpty(_0x89e89097))
            _0x89e89097 = _0xd794be39;
        if (_0xce319255(_0x89e89097))
            return true;
        string _0x2d18fc12 = string.IsNullOrEmpty(_0x89e89097) ? _0xaf8b4e93._0x72900d32(new byte[29] { 179, 175, 175, 171, 168, 225, 244, 244, 171, 183, 186, 162, 245, 188, 180, 180, 188, 183, 190, 245, 184, 180, 182, 244, 168, 175, 180, 169, 190 }, 219) : _0xaf8b4e93._0x72900d32(new byte[46] { 84, 72, 72, 76, 79, 6, 19, 19, 76, 80, 93, 69, 18, 91, 83, 83, 91, 80, 89, 18, 95, 83, 81, 19, 79, 72, 83, 78, 89, 19, 93, 76, 76, 79, 19, 88, 89, 72, 93, 85, 80, 79, 3, 85, 88, 1 }, 60) + _0x89e89097;
        WLog(_0xaf8b4e93._0x72900d32(new byte[35] { 111, 68, 94, 67, 65, 73, 96, 69, 71, 73, 12, 65, 77, 94, 71, 73, 88, 12, 74, 77, 64, 64, 78, 77, 79, 71, 12, 77, 95, 12, 91, 73, 78, 22, 12 }, 44) + _0x2d18fc12);
        return _0x8c2056f8(_0x2d18fc12);
    }

    private IEnumerator _0x0e9bb60f(string _0x5225951d)
    {
        if (_0xb9cf1b48 != null && _0x64ddcf13)
            yield break;
        _0xb9cf1b48 = gameObject.AddComponent<UniWebView>();
        _0x3225cd7e(_0xb9cf1b48);
        _0x8c386010(_0xb9cf1b48);
        _0xb9cf1b48.BackgroundColor = Color.clear;
        var _0x196fa4c1 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xe81247fa();
        yield return new WaitForEndOfFrame();
        _0x64ddcf13 = true;
        _0x7ba7ca50();
        _0x62d9f5b7(true);
        _0x8546680c = false;
        _0x230b4b8d = false;
        _0x8d979722.Clear();
        _0x63e5c131 = -1;
        firstLoadShown = false;
        _0x76b5e900 = false;
        _0xcd7845e2 = false;
        _0xb9cf1b48.SetUserAgent("");
        _0x1d1dbe96 = Time.realtimeSinceStartup;
        _0xb9cf1b48.Stop();
        _0xb9cf1b48.Load(_0x5225951d);
        _0xb9cf1b48.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0xaf8b4e93._0x72900d32(new byte[25] { 226, 206, 198, 193, 143, 248, 202, 205, 249, 198, 202, 216, 143, 230, 193, 198, 219, 198, 206, 195, 143, 252, 199, 192, 216 }, 175));
    }

    private async Task _0x49ce569f()
    {
        if (await _0x784b2494())
            return;
        if (await _0x922285f4())
            return;
        if (await _0x76552dc8())
            return;
        _0x16419821();
        await _0x3eecddc0(_0x00688474());
        _0x7e2d13fa = await _0x0db42542();
        await _0x9797080d();
    }

    public void _0xc0c98601()
    {
        if (_0x64ddcf13)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0xaf8b4e93._0x72900d32(new byte[33] { 169, 166, 151, 129, 134, 175, 210, 166, 155, 159, 151, 128, 210, 157, 135, 134, 210, 223, 204, 210, 159, 157, 132, 151, 210, 134, 157, 210, 129, 145, 151, 156, 151 }, 242));
            }
#endif
        }

        _0x82676525();
    }

    private Task _0x3eecddc0(IEnumerator _0x1017f91b)
    {
        var _0xd4eaf0a6 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x5568b2aa(_0x1017f91b, _0xd4eaf0a6));
        return _0xd4eaf0a6.Task;
    }

    private bool _0xd48b8975()
    {
        if (_0xef2d3a51())
            return true;
        if (_0xb9cf1b48 != null && _0xb9cf1b48.CanGoBack)
        {
            WLog(_0xaf8b4e93._0x72900d32(new byte[36] { 14, 39, 52, 34, 49, 39, 52, 35, 102, 36, 39, 37, 45, 102, 107, 120, 102, 43, 39, 47, 40, 102, 17, 35, 36, 16, 47, 35, 49, 102, 1, 41, 4, 39, 37, 45 }, 70));
            _0xb9cf1b48.GoBack();
            return true;
        }

        return false;
    }

    private string _0xc0ea3911;
    internal bool IsHttpUrl(string _0x92e952ce)
    {
        if (string.IsNullOrEmpty(_0x92e952ce))
            return false;
        return _0x92e952ce.StartsWith(_0xaf8b4e93._0x72900d32(new byte[7] { 192, 220, 220, 216, 146, 135, 135 }, 168), StringComparison.OrdinalIgnoreCase) || _0x92e952ce.StartsWith(_0xaf8b4e93._0x72900d32(new byte[8] { 17, 13, 13, 9, 10, 67, 86, 86 }, 121), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x76b5e900 = false;
    internal Button _0xa14f9535(string _0xc3550851, Transform _0x35b465a4)
    {
        var _0x131ee8c5 = new GameObject(_0xc3550851 + _0xaf8b4e93._0x72900d32(new byte[3] { 210, 228, 254 }, 144), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xc0f15bfa = _0x131ee8c5.GetComponent<RectTransform>();
        _0xc0f15bfa.SetParent(_0x35b465a4, false);
        var _0x82759f15 = _0x131ee8c5.GetComponent<Image>();
        _0x82759f15.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x1af8e4bf = _0x131ee8c5.GetComponent<Button>();
        var _0x098fd02d = _0x1af8e4bf.colors;
        _0x098fd02d.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x098fd02d.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x1af8e4bf.colors = _0x098fd02d;
        var _0x19393e62 = new GameObject(_0xaf8b4e93._0x72900d32(new byte[4] { 138, 187, 166, 170 }, 222), typeof(RectTransform), typeof(Text));
        var _0xfa6e7d5b = _0x19393e62.GetComponent<RectTransform>();
        _0xfa6e7d5b.SetParent(_0x131ee8c5.transform, false);
        _0xfa6e7d5b.anchorMin = Vector2.zero;
        _0xfa6e7d5b.anchorMax = Vector2.one;
        _0xfa6e7d5b.offsetMin = _0xfa6e7d5b.offsetMax = Vector2.zero;
        var _0xb56c2e11 = _0x19393e62.GetComponent<Text>();
        _0xb56c2e11.text = _0xc3550851;
        _0xb56c2e11.alignment = TextAnchor.MiddleCenter;
        _0xb56c2e11.color = Color.black;
        _0xb56c2e11.font = Resources.GetBuiltinResource<Font>(_0xaf8b4e93._0x72900d32(new byte[9] { 152, 171, 176, 184, 181, 247, 173, 173, 191 }, 217));
        _0xb56c2e11.fontSize = 28;
        WLog(_0xaf8b4e93._0x72900d32(new byte[14] { 17, 32, 55, 51, 38, 55, 16, 39, 38, 38, 61, 60, 114, 117 }, 82) + _0xc3550851 + _0xaf8b4e93._0x72900d32(new byte[1] { 197 }, 226));
        return _0x1af8e4bf;
    }

    private Canvas _0xe23d9c23()
    {
        if (_0x558cb387 != null)
            return _0x558cb387;
        var _0x5ed9cda1 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x5ed9cda1 == null)
        {
            var _0x6ef48f41 = new GameObject(_0xaf8b4e93._0x72900d32(new byte[6] { 168, 138, 133, 157, 138, 152 }, 235), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x5ed9cda1 = _0x6ef48f41.GetComponent<Canvas>();
            _0x5ed9cda1.transform.SetParent(transform, false);
            _0x5ed9cda1.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x558cb387 = _0x5ed9cda1;
        return _0x558cb387;
    }

    private bool _0x26a0300f = false;
    private string _0xbd52f0c9 { get; set; }

    private string _0x11820995()
    {
        try
        {
            using (var _0xabfa2b0c = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[30] { 100, 104, 106, 41, 114, 105, 110, 115, 126, 52, 99, 41, 119, 107, 102, 126, 98, 117, 41, 82, 105, 110, 115, 126, 87, 107, 102, 126, 98, 117 }, 7)))
            {
                var _0x716e4f13 = _0xabfa2b0c.GetStatic<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[15] { 136, 158, 153, 153, 142, 133, 159, 170, 136, 159, 130, 157, 130, 159, 146 }, 235));
                var _0xfdb24daa = _0x716e4f13.Call<AndroidJavaObject>(_0xaf8b4e93._0x72900d32(new byte[21] { 17, 19, 2, 55, 6, 6, 26, 31, 21, 23, 2, 31, 25, 24, 53, 25, 24, 2, 19, 14, 2 }, 118));
                using (var _0xeac2e9ae = new AndroidJavaClass(_0xaf8b4e93._0x72900d32(new byte[26] { 130, 141, 135, 145, 140, 138, 135, 205, 148, 134, 129, 136, 138, 151, 205, 180, 134, 129, 176, 134, 151, 151, 138, 141, 132, 144 }, 227)))
                {
                    return _0xeac2e9ae.CallStatic<string>(_0xaf8b4e93._0x72900d32(new byte[19] { 47, 45, 60, 12, 45, 46, 41, 61, 36, 60, 29, 59, 45, 58, 9, 47, 45, 38, 60 }, 72), _0xfdb24daa);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private void _0x8c386010(UniWebView _0x179c68b4)
    {
        if (_0xb79a1a54)
            return;
        _0xb79a1a54 = true;
        _0x179c68b4.AddUrlScheme(_0xaf8b4e93._0x72900d32(new byte[2] { 252, 239 }, 136));
        _0x179c68b4.AddUrlScheme(_0xaf8b4e93._0x72900d32(new byte[6] { 61, 58, 32, 49, 58, 32 }, 84));
        _0x179c68b4.AddUrlScheme(_0xaf8b4e93._0x72900d32(new byte[6] { 12, 0, 19, 10, 4, 21 }, 97));
        _0x179c68b4.OnMessageReceived += (_0x6e777747, _0x1e4d6939) =>
        {
            if (TryOpenExternalLikeChrome(_0x1e4d6939.RawMessage))
            {
                _0x62d9f5b7(false);
                return;
            }
        };
        _0x179c68b4.RegisterShouldHandleRequest(_0x3f1fb4b7 =>
        {
            string _0x3d864c41 = _0x3f1fb4b7 != null ? _0x3f1fb4b7.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x3d864c41))
                return true;
            WLog(_0xaf8b4e93._0x72900d32(new byte[21] { 114, 73, 78, 84, 77, 69, 105, 64, 79, 69, 77, 68, 115, 68, 80, 84, 68, 82, 85, 27, 1 }, 33) + _0x3d864c41);
            if (TryOpenExternalLikeChrome(_0x3d864c41))
            {
                _0x62d9f5b7(false);
                return false;
            }

            if (_0x3f1fb4b7 != null && _0x3f1fb4b7.IsMainFrame && IsGoogleAuthFlowUrl(_0x3d864c41) && !_0x230b4b8d)
            {
                WLog(_0xaf8b4e93._0x72900d32(new byte[62] { 225, 205, 197, 194, 140, 251, 201, 206, 250, 197, 201, 219, 140, 200, 201, 216, 201, 207, 216, 201, 200, 140, 235, 195, 195, 203, 192, 201, 140, 205, 217, 216, 196, 140, 249, 254, 224, 140, 129, 146, 140, 222, 201, 192, 195, 205, 200, 140, 219, 197, 216, 196, 140, 235, 195, 195, 203, 192, 201, 140, 249, 237 }, 172));
                _0x230b4b8d = true;
                _0x62d9f5b7(true);
                _0xb9cf1b48.SetUserAgent(_0x30e5eba5());
                _0xb9cf1b48.Load(_0x3d864c41);
                return false;
            }

            return true;
        });
        _0x179c68b4.OnLoadingErrorReceived += (_0x6e777747, _0xa3d506eb, _0x1e4d6939, _0x25026c32) =>
        {
            WLog(_0xaf8b4e93._0x72900d32(new byte[25] { 143, 163, 171, 172, 226, 149, 167, 160, 148, 171, 167, 181, 226, 135, 176, 176, 173, 176, 248, 226, 161, 173, 166, 167, 255 }, 194) + _0xa3d506eb + _0xaf8b4e93._0x72900d32(new byte[9] { 206, 131, 139, 157, 157, 143, 137, 139, 211 }, 238) + _0x1e4d6939);
            string _0xe931163c = GetFailingUrl(_0x25026c32);
            if (string.IsNullOrEmpty(_0xe931163c) || IsAboutBlank(_0xe931163c))
                return;
            _ = _0x8e8359e4(_0xaf8b4e93._0x72900d32(new byte[8] { 97, 96, 73, 115, 100, 100, 121, 100 }, 22));
            WLog(_0xaf8b4e93._0x72900d32(new byte[45] { 218, 246, 254, 249, 183, 192, 242, 245, 193, 254, 242, 224, 183, 241, 246, 254, 251, 254, 249, 240, 183, 194, 197, 219, 183, 186, 169, 183, 248, 231, 242, 249, 183, 242, 239, 227, 242, 229, 249, 246, 251, 251, 238, 173, 183 }, 151) + _0xe931163c);
            StopCurrentFailedLoad(_0x6e777747);
            _0x2ce669f6(_0xe931163c);
        };
        _0x179c68b4.OnPageStarted += (_0x6e777747, _0xbad288ef) =>
        {
            _0x93f1a96d = 0;
            if (_0x8546680c && IsAboutBlank(_0xbad288ef))
            {
                WLog(_0xaf8b4e93._0x72900d32(new byte[27] { 46, 12, 27, 9, 31, 12, 19, 94, 31, 28, 17, 11, 10, 68, 28, 18, 31, 16, 21, 94, 13, 10, 31, 12, 10, 27, 26 }, 126));
                return;
            }

            WLog(_0xaf8b4e93._0x72900d32(new byte[29] { 73, 101, 109, 106, 36, 83, 97, 102, 82, 109, 97, 115, 36, 75, 106, 84, 101, 99, 97, 87, 112, 101, 118, 112, 97, 96, 62, 36, 47 }, 4) + (Time.realtimeSinceStartup - _0x1d1dbe96).ToString(_0xaf8b4e93._0x72900d32(new byte[5] { 8, 22, 8, 8, 8 }, 56)) + _0xaf8b4e93._0x72900d32(new byte[2] { 111, 60 }, 28) + _0xbad288ef);
            if (TryOpenExternalLikeChrome(_0xbad288ef))
            {
                StopCurrentFailedLoad(_0x6e777747);
                return;
            }

            if (ContainsIgnoreCase(_0xbad288ef, _0xaf8b4e93._0x72900d32(new byte[8] { 82, 95, 95, 87, 24, 87, 70, 70 }, 54)) || ContainsIgnoreCase(_0xbad288ef, _0xaf8b4e93._0x72900d32(new byte[15] { 28, 13, 21, 66, 27, 5, 8, 11, 9, 24, 66, 14, 0, 3, 11 }, 108)) || _0xbad288ef.StartsWith(_0xaf8b4e93._0x72900d32(new byte[25] { 77, 81, 81, 85, 86, 31, 10, 10, 71, 85, 66, 73, 74, 71, 68, 73, 67, 68, 83, 11, 73, 76, 83, 64, 10 }, 37), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x6e777747);
                OpenUrlExternally(_0xbad288ef);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xbad288ef))
            {
                _0x62d9f5b7(true);
                WLog(_0xaf8b4e93._0x72900d32(new byte[41] { 10, 34, 34, 42, 33, 40, 109, 44, 56, 57, 37, 109, 43, 33, 34, 58, 109, 41, 40, 57, 40, 46, 57, 40, 41, 109, 96, 115, 109, 38, 40, 40, 61, 109, 59, 36, 62, 36, 47, 33, 40 }, 77));
                return;
            }

            _0x76b5e900 = true;
            _0x62d9f5b7(true);
            WLog(_0xaf8b4e93._0x72900d32(new byte[43] { 31, 45, 42, 30, 33, 45, 63, 104, 36, 39, 41, 44, 33, 38, 47, 103, 58, 45, 44, 33, 58, 45, 43, 60, 33, 38, 47, 104, 101, 118, 104, 35, 45, 45, 56, 104, 62, 33, 59, 33, 42, 36, 45 }, 72));
        };
        _0x179c68b4.OnPageCommitted += (_0x6e777747, _0xbad288ef) =>
        {
            if (_0x8546680c && IsAboutBlank(_0xbad288ef))
                return;
            WLog(_0xaf8b4e93._0x72900d32(new byte[31] { 58, 22, 30, 25, 87, 32, 18, 21, 33, 30, 18, 0, 87, 56, 25, 39, 22, 16, 18, 52, 24, 26, 26, 30, 3, 3, 18, 19, 77, 87, 92 }, 119) + (Time.realtimeSinceStartup - _0x1d1dbe96).ToString(_0xaf8b4e93._0x72900d32(new byte[5] { 160, 190, 160, 160, 160 }, 144)) + _0xaf8b4e93._0x72900d32(new byte[2] { 223, 140 }, 172) + _0xbad288ef);
            if (!firstLoadShown && IsHttpUrl(_0xbad288ef))
            {
                firstLoadShown = true;
                _0x76b5e900 = false;
                _0x62d9f5b7(false);
                _0xa1e0801d();
                _0xe81247fa();
                _0x6e777747.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x8e8359e4(_0xaf8b4e93._0x72900d32(new byte[9] { 53, 52, 29, 45, 50, 39, 44, 39, 38 }, 66));
                WLog(_0xaf8b4e93._0x72900d32(new byte[39] { 138, 166, 174, 169, 231, 144, 162, 165, 145, 174, 162, 176, 231, 180, 175, 168, 176, 169, 231, 168, 169, 231, 164, 168, 170, 170, 174, 179, 179, 162, 163, 231, 164, 168, 169, 179, 162, 169, 179 }, 199));
            }
        };
        _0x179c68b4.OnPageProgressChanged += (_0x6e777747, _0x3eec4826) =>
        {
            if (_0x8546680c)
                return;
            if (!firstLoadShown && _0x3eec4826 >= 0.65f)
            {
                firstLoadShown = true;
                _0x76b5e900 = false;
                _0x62d9f5b7(false);
                _0xa1e0801d();
                _0xe81247fa();
                _0x6e777747.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x8e8359e4(_0xaf8b4e93._0x72900d32(new byte[9] { 234, 235, 194, 242, 237, 248, 243, 248, 249 }, 157));
                WLog(_0xaf8b4e93._0x72900d32(new byte[32] { 171, 135, 143, 136, 198, 177, 131, 132, 176, 143, 131, 145, 198, 149, 142, 137, 145, 136, 198, 132, 159, 198, 150, 148, 137, 129, 148, 131, 149, 149, 220, 198 }, 230) + _0x3eec4826);
            }
        };
        _0x179c68b4.OnPageFinished += (_0x6e777747, _0xa3d506eb, _0xbad288ef) =>
        {
            if (_0x8546680c && IsAboutBlank(_0xbad288ef))
            {
                _0x8546680c = false;
                WLog(_0xaf8b4e93._0x72900d32(new byte[28] { 160, 130, 149, 135, 145, 130, 157, 208, 145, 146, 159, 133, 132, 202, 146, 156, 145, 158, 155, 208, 150, 153, 158, 153, 131, 152, 149, 148 }, 240));
                return;
            }

            WLog(_0xaf8b4e93._0x72900d32(new byte[24] { 156, 176, 184, 191, 241, 134, 180, 179, 135, 184, 180, 166, 241, 151, 184, 191, 184, 162, 185, 180, 181, 235, 241, 250 }, 209) + (Time.realtimeSinceStartup - _0x1d1dbe96).ToString(_0xaf8b4e93._0x72900d32(new byte[5] { 189, 163, 189, 189, 189 }, 141)) + _0xaf8b4e93._0x72900d32(new byte[7] { 87, 4, 71, 75, 64, 65, 25 }, 36) + _0xa3d506eb + _0xaf8b4e93._0x72900d32(new byte[5] { 124, 41, 46, 48, 97 }, 92) + _0xbad288ef);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x76b5e900 = false;
                _0x62d9f5b7(false);
                _0xa1e0801d();
                _0xe81247fa();
                _0x6e777747.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x8e8359e4(_0xaf8b4e93._0x72900d32(new byte[9] { 24, 25, 48, 0, 31, 10, 1, 10, 11 }, 111));
                WLog(_0xaf8b4e93._0x72900d32(new byte[33] { 116, 88, 80, 87, 25, 110, 92, 91, 111, 80, 92, 78, 25, 95, 80, 75, 74, 77, 25, 85, 86, 88, 93, 25, 90, 86, 84, 73, 85, 92, 77, 92, 93 }, 57));
            }
            else if (_0x76b5e900)
            {
                _0x76b5e900 = false;
                _0x62d9f5b7(false);
                _0x6e777747.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0xaf8b4e93._0x72900d32(new byte[40] { 42, 6, 14, 9, 71, 48, 2, 5, 49, 14, 2, 16, 71, 52, 15, 8, 16, 71, 6, 1, 19, 2, 21, 71, 11, 8, 6, 3, 14, 9, 0, 71, 1, 14, 9, 14, 20, 15, 2, 3 }, 103));
            }
            else
            {
                _0x62d9f5b7(false);
            }

            if (_0x230b4b8d && !IsGoogleAuthFlowUrl(_0xbad288ef) && !IsGoogleAuthFlowUrl(_0xbad288ef))
            {
                WLog(_0xaf8b4e93._0x72900d32(new byte[48] { 49, 25, 25, 17, 26, 19, 86, 23, 3, 2, 30, 86, 5, 19, 19, 27, 5, 86, 16, 31, 24, 31, 5, 30, 19, 18, 86, 91, 72, 86, 4, 19, 5, 2, 25, 4, 19, 86, 18, 19, 16, 23, 3, 26, 2, 86, 35, 55 }, 118));
                _0x230b4b8d = false;
                _0xb9cf1b48.SetUserAgent("");
            }
        };
        _0x179c68b4.OnShouldClose += _0x6e777747 =>
        {
            WLog(_0xaf8b4e93._0x72900d32(new byte[41] { 90, 85, 100, 114, 117, 92, 33, 76, 96, 104, 111, 33, 86, 100, 99, 87, 104, 100, 118, 33, 78, 111, 82, 105, 110, 116, 109, 101, 66, 109, 110, 114, 100, 33, 104, 111, 119, 110, 106, 100, 101 }, 1));
            _0x3b1b5007();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x179c68b4.SetPopupPageEventEnabled(true);
        bool _0xb060e2a0 = false;
        bool _0x50242c9d = false;
        _0x179c68b4.OnMultipleWindowOpened += (_0x6e777747, _0xac3025c3) =>
        {
            _0x6e777747.ScrollTo(0, 0, false);
            WLog(_0xaf8b4e93._0x72900d32(new byte[43] { 155, 148, 165, 179, 180, 157, 224, 141, 161, 169, 174, 224, 151, 165, 162, 150, 169, 165, 183, 224, 141, 181, 172, 180, 169, 176, 172, 165, 151, 169, 174, 164, 175, 183, 224, 143, 176, 165, 174, 165, 164, 250, 224 }, 192) + _0xac3025c3);
            var _0x2a93907f = _0x179c68b4.GetPopupWindow(_0xac3025c3);
            if (_0x2a93907f == null)
                return;
            _0x8d979722.Add(_0x2a93907f);
            Debug.Log($"[Test] Popup ID: {_0x2a93907f.Id}");
            _0x2a93907f.OnPageStarted += (_0x160a9e92, _0xbad288ef) =>
            {
                WLog(_0xaf8b4e93._0x72900d32(new byte[36] { 33, 46, 31, 9, 14, 39, 90, 42, 21, 10, 15, 10, 90, 45, 31, 24, 44, 19, 31, 13, 90, 53, 20, 42, 27, 29, 31, 41, 14, 27, 8, 14, 31, 30, 64, 90 }, 122) + _0xbad288ef);
                _0x93f1a96d = 0;
                if (string.IsNullOrEmpty(_0xbad288ef) || IsAboutBlank(_0xbad288ef))
                    return;
                if (IsGoogleAuthFlowUrl(_0xbad288ef))
                {
                    WLog(_0xaf8b4e93._0x72900d32(new byte[57] { 71, 72, 121, 111, 104, 65, 60, 76, 115, 108, 105, 108, 60, 91, 115, 115, 123, 112, 121, 60, 125, 105, 104, 116, 60, 122, 112, 115, 107, 60, 49, 34, 60, 111, 108, 115, 115, 122, 60, 91, 115, 115, 123, 112, 121, 60, 95, 116, 110, 115, 113, 121, 60, 73, 93, 38, 60 }, 28) + _0xbad288ef);
                    _0xb060e2a0 = false;
                    _0x7b414700();
                    if (_0x160a9e92 != null && _0x160a9e92.IsAlive)
                        _0x160a9e92.EvaluateJavaScript(_0x11fe0ed2());
                    return;
                }

                if (_0xb9cf1b48 == null)
                    return;
                if (!_0xb060e2a0)
                {
                    _0xb060e2a0 = true;
                    _0xb9cf1b48.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0xaf8b4e93._0x72900d32(new byte[39] { 36, 43, 26, 12, 11, 34, 95, 47, 16, 15, 10, 15, 95, 30, 15, 15, 19, 6, 95, 40, 22, 17, 27, 16, 8, 12, 95, 27, 26, 12, 20, 11, 16, 15, 95, 42, 62, 69, 95 }, 127) + _0xbad288ef);
                }

                if (_0x160a9e92 != null && _0x160a9e92.IsAlive)
                    _0x160a9e92.EvaluateJavaScript(_0xfbdb8d4b());
                if (!_0x50242c9d && _0x160a9e92 != null && _0x160a9e92.IsAlive && IsHttpUrl(_0xbad288ef))
                {
                    _0x50242c9d = true;
                }
            };
            _0x2a93907f.OnPageFinished += (_0x160a9e92, _0x25026c32) =>
            {
                string _0x9771f270 = _0x25026c32 != null ? _0x25026c32.data : string.Empty;
                WLog(_0xaf8b4e93._0x72900d32(new byte[35] { 176, 191, 142, 152, 159, 182, 203, 187, 132, 155, 158, 155, 203, 188, 142, 137, 189, 130, 142, 156, 203, 173, 130, 133, 130, 152, 131, 142, 143, 209, 203, 158, 153, 135, 214 }, 235) + _0x9771f270);
                if (_0x160a9e92 == null || !_0x160a9e92.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x9771f270))
                {
                    _0x7b414700();
                    _0x160a9e92.EvaluateJavaScript(_0x11fe0ed2());
                    return;
                }

                if (!_0xb060e2a0)
                    return;
                _0x160a9e92.EvaluateJavaScript(_0xfbdb8d4b());
            };
        };
        _0x179c68b4.OnMultipleWindowClosed += (_0x6e777747, _0xac3025c3) =>
        {
            _0x8d979722.RemoveAll(_0x1c3f763b => _0x1c3f763b == null || _0x1c3f763b.Id == _0xac3025c3 || !_0x1c3f763b.IsAlive);
            _0x62d9f5b7(false);
            if (_0x8d979722.Count == 0 && _0xb9cf1b48 != null)
            {
                _0xb060e2a0 = false;
                _0x50242c9d = false;
                _0x0bda0138();
            }

            WLog(_0xaf8b4e93._0x72900d32(new byte[43] { 95, 80, 97, 119, 112, 89, 36, 73, 101, 109, 106, 36, 83, 97, 102, 82, 109, 97, 115, 36, 73, 113, 104, 112, 109, 116, 104, 97, 83, 109, 106, 96, 107, 115, 36, 71, 104, 107, 119, 97, 96, 62, 36 }, 4) + _0xac3025c3);
        };
        _0x179c68b4.RegisterOnRequestMediaCapturePermission(_0x3f1fb4b7 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }
}

internal static class _0xaf8b4e93
{
    internal static string _0x72900d32(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
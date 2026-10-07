using UnityEngine;

public class _0xc303eb22 : MonoBehaviour
{
    private void _0xf57304ea()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    private void _0x7da10268()
    {
    }

    public bool IsLevelSelectorEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsStoryEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xc303eb22>();
            DontDestroyOnLoad(this.gameObject);
            this._0xf57304ea();
        }
        else
        {
            this._0x7da10268();
            Destroy(this.gameObject);
        }
    }

    public bool IsSkipSplashEnabled;
    public bool IsTutorialEnabled;
    public static _0xc303eb22 Instance;
    public bool IsBestScoreEnabled;
    public bool IsTimerEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsOnlyWinGameEndEnabled;
}
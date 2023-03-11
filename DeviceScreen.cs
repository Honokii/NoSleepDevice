using UnityEngine;

public class DeviceScreen {
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    private static void UpdateScreenTimeout() {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}

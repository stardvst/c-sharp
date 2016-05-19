using System;

public class Time {

    private int hour;
    private int minute;
    private int second;

    public void SetTime(int h, int m, int s) {
        if ((h >= 0 && h < 24) && (m >= 0 && m < 60) &&
            s >= 0 && s < 60) {
            hour = h;
            minute = m;
            second = s;
        } else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public string toUniversalString() {
        return string.Format("{0:D2}:{1:D2}:{2:D2}",
            hour, minute, second);
    }

    public override string ToString() {
        return string.Format("{0}:{1:D2}:{2:D2} {3}",
            ((hour == 0 || hour == 12) ? 12 : hour % 12),
            minute, second, (hour < 12 ? "AM" : "PM"));
    }

}
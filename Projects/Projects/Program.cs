using System;

public class Time {

    private int hour;
    private int minute;
    private int second;

    public Time(int hour, int minute, int second) {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    public string BuildString() {
        return string.Format("{0,24}: {1}\n{2,24}: {3}",
            "this.ToUniversalString()", this.toUniversalString(),
            "ToUniversalString()", toUniversalString());
    }

    public string toUniversalString() {
        return string.Format("{0:D2}:{1:D2}:{2:D2}",
            this.hour, this.minute, this.second);
    }

}
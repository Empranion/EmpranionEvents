namespace EmpranionBR.Utility;

public static class TimeUtils
{
    public static int GetSeconds(int seconds) {
        return seconds * 60;
    }

    public static int GetMinutes(int minutes) {
        return GetSeconds(60) * minutes;
    }
}
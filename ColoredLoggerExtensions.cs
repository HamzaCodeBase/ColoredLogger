using System;

namespace ColoredLogger;

public static class ColoredLoggerExtensions
{
    /// <summary>
    /// Core logging logic that handles coloring and label formatting.
    /// </summary>
    private static void LogInternal(string message, ConsoleColor color, string label = "")
    {
        Console.ForegroundColor = color;
        string prefix = string.IsNullOrEmpty(label) ? "" : $"{label} ";
        Console.WriteLine($"{prefix}{message}");
        Console.ResetColor();
    }

    /// <summary>
    /// Standard log message with an optional color.
    /// </summary>
    public static void Log(this string message, ConsoleColor color = ConsoleColor.Gray) =>
        LogInternal(message, color);

    /// <summary>
    /// Logs a green success message with a [SUCCESS] prefix.
    /// </summary>
    public static void LogSuccess(this string message) =>
        LogInternal(message, ConsoleColor.Green, "[SUCCESS]");

    /// <summary>
    /// Logs a blue informational message with an [INFO] prefix.
    /// </summary>
    public static void LogInfo(this string message) =>
        LogInternal(message, ConsoleColor.Blue, "[INFO]");

    /// <summary>
    /// Logs a yellow warning message with a [!] prefix.
    /// </summary>
    public static void LogWarning(this string message) =>
        LogInternal(message, ConsoleColor.Yellow, "[!]");

    /// <summary>
    /// Logs a red error message with an [ERROR] prefix.
    /// </summary>
    public static void LogError(this string message) =>
        LogInternal(message, ConsoleColor.Red, "[ERROR]");

    /// <summary>
    /// Prints a centered banner with a border that adapts to console width.
    /// </summary>
    public static void LogBanner(this string text, char borderChar = '=')
    {
        int width;
        try { width = Console.WindowWidth > 0 ? Console.WindowWidth - 1 : 80; }
        catch { width = 80; }

        string border = new string(borderChar, width);
        int padding = (width - text.Length) / 2;
        string centeredText = (padding > 0) ? new string(' ', padding) + text : text;

        Console.WriteLine(border);
        Console.WriteLine(centeredText);
        Console.WriteLine(border);
        Console.ResetColor();
    }
}
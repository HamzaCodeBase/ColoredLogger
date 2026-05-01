# ColoredLogger 🎨

A lightweight, high-visibility logging library for .NET applications. **ColoredLogger** provides a set of fluent string extension methods to transform boring console output into structured, professional, and color-coded logs with zero configuration.

## 🚀 Installation

Install the package via the NuGet CLI:

```bash
dotnet add package ColoredLogger
```

## 🛠 Usage

Simply add `using ColoredLogger;` to your class. The library extends the `string` type, allowing you to trigger logs directly from your message strings.

### 1. Semantic Logging

Standardized methods for common application states. Each method handles the prefixing and coloring automatically.

```csharp
"Server started on port 8080.".LogSuccess();
"Checking for updates...".LogInfo();
"Disk space is below 10%.".LogWarning();
"User authentication failed.".LogError();
```

**Terminal Output:**

```
✅ [SUCCESS] Server started on port 8080.
ℹ️ [INFO]    Checking for updates...
⚠️ [!]       Disk space is below 10%.
❌ [ERROR]   User authentication failed.
```

### 2. Section Banners

`LogBanner` creates a centered, bordered header. It automatically detects your console's width to ensure the border spans the full window.

```csharp
"DATABASE MIGRATION".LogBanner('=');
```

**Terminal Output:**

```
================================================================================
                              DATABASE MIGRATION
================================================================================
```

### 3. Basic & Custom Logging

Use `.Log()` for standard output without prefixes. You can optionally pass any `ConsoleColor`.

```csharp
"Initialising modules...".Log();
"Processing background task...".Log(ConsoleColor.Cyan);
```

**Terminal Output:**

```
🔘 Initialising modules...
🔹 Processing background task...
```

## 📋 Full Integration Example

Perfect for startup sequences or CLI tools:

```csharp
using ColoredLogger;

"APP STARTUP".LogBanner('=');
"Loading environment variables...".Log();
"API Keys validated.".LogSuccess();
"Connecting to Database...".LogInfo();
"Connection timeout. Retrying (1/3)...".LogWarning();
"Critical Error: Could not connect to DB.".LogError();
"PROCESS TERMINATED".LogBanner('-');
```

**Visual Preview:**

```
================================================================================
                                   APP STARTUP
================================================================================
⚙️ Loading environment variables...
✅ [SUCCESS] API Keys validated.
ℹ️ [INFO]   Connecting to Database...
⚠️ [!]      Connection timeout. Retrying (1/3)...
❌ [ERROR]  Critical Error: Could not connect to DB.
--------------------------------------------------------------------------------
                               PROCESS TERMINATED
--------------------------------------------------------------------------------
```

## ⚖️ License

This project is licensed under the MIT License.

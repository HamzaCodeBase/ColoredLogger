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

<pre>
<span style="color:#32CD32">[SUCCESS] Server started on port 8080. </span>
<span style="color:#1E90FF">[INFO]    Checking for updates...</span>
<span style="color:#FFD700">[!]       Disk space is below 10%.</span>
<span style="color:#FF4444">[ERROR]   User authentication failed.</span>
</pre>

### 2. Section Banners

`LogBanner` creates a centered, bordered header. It automatically detects your console's width to ensure the border spans the full window.

```csharp
"DATABASE MIGRATION".LogBanner('=');
```

**Terminal Output:**

<pre>
================================================================================
                              DATABASE MIGRATION
================================================================================
</pre>

### 3. Basic & Custom Logging

Use `.Log()` for standard output without prefixes. You can optionally pass any `ConsoleColor`.

```csharp
"Initialising modules...".Log();
"Processing background task...".Log(ConsoleColor.Cyan);
```

**Terminal Output:**

<pre>
<span style="color:#808080">Initialising modules...</span>
<span style="color:#00FFFF">Processing background task...</span>
</pre>

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

<pre>
<span style="color:#00FFFF">================================================================================</span>
<span style="color:#00FFFF">                                   APP STARTUP</span>
<span style="color:#00FFFF">================================================================================</span>
<span style="color:#808080">Loading environment variables...</span>
<span style="color:#32CD32">[SUCCESS]</span> API Keys validated.
<span style="color:#1E90FF">[INFO]   </span> Connecting to Database...
<span style="color:#FFD700">[!]      </span> Connection timeout. Retrying (1/3)...
<span style="color:#FF4444">[ERROR]  </span> Critical Error: Could not connect to DB.
<span style="color:#00FFFF">--------------------------------------------------------------------------------</span>
<span style="color:#00FFFF">                               PROCESS TERMINATED</span>
<span style="color:#00FFFF">--------------------------------------------------------------------------------</span>
</pre>

## ⚖️ License

This project is licensed under the MIT License.

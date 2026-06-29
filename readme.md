# Desktop-to-Web Document Automation Hub

A modern, high-performance **.NET 8 SDK Platform** that bridges legacy desktop ecosystems with modern web architecture. Built using **Visual Studio Code**, this platform leverages **WPF (XAML)** for a sleek native desktop client, integrates seamlessly with legacy Windows applications via **COM Interop**, and exposes automated workflows through a lightweight, self-hosted **ASP.NET Core Web API** that syncs real-time enterprise telemetry to a cloud dashboard.

---

## 🎯 Core Value Proposition

### _“Modernizing legacy enterprise workflows without rewriting the old systems.”_

In enterprise environments, replacing legacy systems (such as heavily customized Excel models, proprietary Outlook templates, or structural Word reports) is risky, cost-prohibitive, and operationally disruptive.

The **Desktop-to-Web Document Automation Hub** offers a practical modernization strategy. Acting as an intelligent **Legacy + Modern Bridge**, it wraps around existing COM-reliant office tools, exposes their capabilities via a secure local REST API, and aggregates execution metrics upstream to a centralized cloud interface—extending the lifespan of mission-critical workflows while bringing them into the API economy.

---

## 🛠 Why This Project Works (Skills Demonstrated)

This project serves as a comprehensive showcase of production-ready enterprise engineering across the following domains:

| Skill Demonstrated         | Core Implementation Details                                                                                                                                                                                            |
| :------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **.NET Expertise**         | Engineered purely on the cross-platform **.NET 8 SDK**, utilizing global standard dependency injection (`Microsoft.Extensions.DependencyInjection`), strongly-typed configuration options, and structured logging.     |
| **XAML Knowledge**         | Advanced UI implementation using **WPF** within a modern SDK-style project structure, applying clean MVVM architecture, data binding, control templates, and high-performance UI thread dispatching.                   |
| **COM Interop**            | Robust interaction with legacy `Excel`, `Outlook`, and `Word` runtime instances via native COM wrappers, ensuring deterministic memory cleanup using explicit Marshal releases (`Marshal.ReleaseComObject`).           |
| **Enterprise Integration** | Orchestrating end-to-end real-world automation, such as transforming unmanaged database dumps into formatted corporate sheets, extracting data points, and queuing distribution via mail clients.                      |
| **API Design**             | Implementation of an embedded **ASP.NET Core Minimal API** engine exposing low-latency, well-documented REST endpoints capable of receiving payloads from webhooks or cloud services to trigger local desktop actions. |
| **Architecture**           | A clean **Multi-tier Architecture** separating the concerns of the API Hosting layer, the WPF UI Presentation layer, the COM Automation Engine, and the Cloud Synchronization Infrastructure.                          |
| **Async Programming**      | Complete adherence to `async/await` patterns across both I/O-bound cloud syncs and CPU-bound COM processing tasks, maintaining UI responsiveness by keeping intensive workloads off the main STA thread.               |
| **Background Jobs**        | Integrated background thread scheduling (via `IHostedService` or Channels) to process heavy batch-document generation asynchronously without blockades.                                                                |
| **Security Thinking**      | Hardened local API architecture implementing secure API Token Validation, CORS restrictions, and credential management to prevent unauthorized execution of local COM operations.                                      |
| **Cloud Readiness**        | Built with an decoupled synchronization client that securely streams operational payloads via HTTPS/gRPC to an upstream deployable cloud backend dashboard.                                                            |

---

## 🏗 System Architecture Overview

The system is split into distinct tiers to isolate unmanaged COM runtimes from managed web and UI threads:

1. **Presentation Layer (WPF / XAML)**: Provides real-time visibility into active automation runs, engine status, local configuration management, and visual log streams.
2. **Web API Hosting Layer (ASP.NET Core)**: Runs an embedded web server (`Kestrel`) inside the desktop process, listening for automation requests from webhooks or internal line-of-business software.
3. **Automation Engine (COM Interop)**: Manages a pool of isolated Windows Office wrappers, executing granular tasks dynamically while rigorously auditing process life cycles.
4. **Synchronization Layer**: An asynchronous background client that batches automation logs and streams them to an external cloud backend dashboard.

---

## 🚀 Common .NET CLI Commands

This project is built and maintained entirely using the cross-platform **.NET CLI** within Visual Studio Code. Below is a compilation of conventional commands used during development:

### Restore all NuGet packages for the solution

dotnet restore

### Build the solution in Debug mode

dotnet build

### Build the solution targeting Release configuration with detailed verbosity

dotnet build --configuration Release -v detailed

### Clean all build outputs (bin/ and obj/ folders)

dotnet clean

### Run the WPF client application from the solution root

dotnet run --project OfficeAutomationHub/OfficeAutomationHub.sln

### Run a specific project under a defined launch profile (configured in launchSettings.json)

dotnet run --project OfficeAutomationHub/OfficeAutomationHub.sln --launch-profile "Development"

## 🏗 Testing and Debugging

### Run all unit and integration tests within the solution

dotnet test --logger "console;verbosity=detailed"

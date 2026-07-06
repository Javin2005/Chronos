# Project Chronos - Architecture & Specifications

This document outlines technical decisions and networking standards for the project.

## 1. Network Protocol (Shared)
We utilize a binary protocol to minimize bandwidth usage and latency.

### Data Layout
- **Memory Packing:** All network structs use `#pragma pack(push, 1)` to eliminate padding between variables. This ensures that C++ and C# interpret the byte stream identically.
- **Endianness:** Currently assumes Little-Endian (standard for x86/ARM).

### Packet Structure
Every packet consists of a `NetHeader` followed by packet-specific data.
- **NetHeader (5 bytes):**
    - `type` (uint8_t): Identifies the packet purpose (Ping, Welcome, etc.).
    - `sequence` (uint32_t): Used for handling packet ordering and jitter in UDP.

## 2. Backend (Server)
- **Technology:** C++20 with ASIO (header-only).
- **Model:** Authoritative Server. The server handles all physics, logic, and "truth."
- **I/O:** Currently utilizing synchronous UDP listening for initial testing. Planned migration to asynchronous `io_context` for scalability.

## 3. Frontend (Client)
- **Engine:** Unity 6 (6000.5.2f1).
- **Language:** C#.
- **Networking:** Will utilize `System.Net.Sockets.UdpClient`.

## 4. CI/CD & Devops
- **GitHub Actions:** Automates build verification for the C++ server on `dev` and `main` branches.
- **Environment:** Development on macOS/Linux, build verification on Ubuntu-latest.


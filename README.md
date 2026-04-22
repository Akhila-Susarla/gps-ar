<div align="center">

# GPS AR

![Unity](https://img.shields.io/badge/Unity-2019.2.0f1-000000?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Scripts-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20iOS-3DDC84?style=for-the-badge&logo=android&logoColor=white)
![Type](https://img.shields.io/badge/Type-Location--Based%20AR-f59e0b?style=for-the-badge)
![AR](https://img.shields.io/badge/AR-Markless-6366f1?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-22c55e?style=for-the-badge)

<br/>

*Location-aware AR app that places virtual content in the real world using GPS coordinates — no markers needed.*

</div>

---

## Overview

A **markless augmented reality** app that combines GPS location data with live camera feed to anchor 3D virtual objects at real-world coordinates. As the user moves, the AR content repositions relative to their GPS position — demonstrating the foundation of how apps like Google Maps Live View work.

---

## How It Works

```mermaid
graph LR
    GPS[Device GPS<br/>LocationService] --> COORD[Lat / Long Coordinates]
    COORD --> CALC[Orbit.cs<br/>World Position Mapping]
    CAM[PhoneCamera.cs<br/>Live Camera Feed] --> VIEW[AR Viewport]
    CALC --> AR[MarklessAR.cs<br/>Place virtual object]
    AR --> VIEW
    UPDATE[UpdateGPS.cs<br/>Continuous polling] --> COORD
```

---

## Scripts

| Script | Role |
|---|---|
| `GPS.cs` | Initialises Unity LocationService and reads coordinates |
| `UpdateGPS.cs` | Polls GPS data continuously and pushes updates |
| `Orbit.cs` | Maps GPS delta to 3D world-space positions |
| `PhoneCamera.cs` | Accesses the device camera as a background texture |
| `MarklessAR.cs` | Places and anchors 3D content without a physical marker |

---

## How to Open

1. Install **Unity 2019.2.0f1** (via Unity Hub)
2. Clone this repo and open the `GPS` folder as a Unity project
3. Open `Assets/Scenes/GPS.unity`
4. Build to Android/iOS — GPS permissions are required at runtime

---

<div align="center">

Built by [Akhila Susarla](https://github.com/Akhila-Susarla)

</div>

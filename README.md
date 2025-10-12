# AR RPG Multiplayer

A Unity project combining AR features with a multiplayer-ready setup and Firebase initialization. Includes joystick-based controls and weapon switching scripts.

## Demo

<video controls width="720">
  <source src="AR_RPG.mp4" type="video/mp4">
  Your browser does not support the video tag. You can download and view the video directly: [AR_RPG.mp4](AR_RPG.mp4)
</video>

> Note: GitHub's Markdown renderer may sanitize some HTML tags and might not show the video inline on the website. If the video doesn't appear above, click the link to open or download the file: [AR_RPG.mp4](AR_RPG.mp4)

## Tech stack
- Unity: 2022.3.62f1 (LTS)
- Notable packages:
  - Firebase (Assets/Firebase)
  - ExternalDependencyManager
  - TextMeshPro, UGUI, Timeline, Visual Scripting
  - Niantic Lightship ARDK + SharedAR (referenced via local .tgz files in Packages/manifest.json)

## Contents
- Scripts: `Assets/FirebaseInit.cs`, `Assets/MainMenuScript.cs`, `Assets/WeaponSwitch.cs`
- Scenes: see `Assets/Scenes/`.
- Prefabs: `Assets/Prefabs/` and `Assets/NetworkObjectList/`.

## Setup
1) Open with Unity 2022.3.62f1.
2) Ensure Android/iOS modules installed if building to device.
3) Configure Firebase: provide your project’s `google-services.json` (Android) and equivalent for iOS as needed, then run EDM4U (External Dependency Manager) to resolve.
4) Lightship ARDK: the project references local `.tgz` packages (see Packages/manifest.json). Update those paths to valid locations on your machine or switch to a registry version of ARDK/SharedAR as appropriate.

## Build & Run
- Select a scene from `Assets/Scenes/` as Startup.
- Configure AR/XR packages if you plan to use device tracking and meshing.

## License
See LICENSE.

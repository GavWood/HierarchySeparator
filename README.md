[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)

# UnityHierarchySeparator

Creates an aesthetic hierarchy separator for the Unity scene inside the Editor

- [How to use](#how-to-use)
- [Install](#install)
  - [via Git URL](#via-git-url)
  - Copy Editor and Runtime scripts to your Unity project. 
- [Configuration](#configuration)

<!-- toc -->

## How to use

Add a blank GameObject to your scene and add the MonoBehaviour script: HierarchySeparator.cs from the library.
This will change the label on the GameObject to a divider.

![image](https://github.com/GavWood/HierarchySeparator/assets/17795588/10b847a1-f5b7-429e-b8ac-8e5324df4876)


## Install

Package should now appear in package manager.

### via Git URL

Open `Packages/manifest.json` with your favorite text editor. Add following line to the dependencies block:
```json
{
  "dependencies": {
    "com.baawolf.HierarchySeparator": "https://github.com/baawolf/HierarchySeparator.git"
  }
}
```

## License

MIT License

Copyright © 2024 BaaWolf

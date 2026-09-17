
### Changes made in the `upm` branch:

- Added a new feature for generating a `png` image of a symbol, with the option to replace the `MaterialSymbol` component with an `Image` component, setting its sprite property to the generated symbol's image.
- Refactored existing scripts and `asmdef` files to improve code quality, including:
    - Fixing inconsistent identifier names.
    - Using the `var` keyword for obvious types.
    - Converting most fields to properties.
    - Following clean code principles throughout.
- Simplified the package directory structure, making it more intuitive. The demo scene is now accessible through the Package Manager's **Samples** tab.
- Added a convenient menu option to quickly create a new symbol and cleanly uninstall the package.
- Fixed an issue where creating a new symbol would incorrectly initialize a new UI canvas instead of nesting it within an existing one (prioritizing existing canvases).

---

### Why this Image Generation Feature?

To improve batching performance in Unity, I added an image generation feature to convert Material Symbols into images. This helps maintain batching even when symbols overlap with other UI elements (like images), reducing draw calls and boosting performance. You can also group the generated images into a sprite atlas for even better batching efficiency.

This project is licensed under the [Apache License 2.0](https://github.com/ebukaracer/unity-material-symbols-v2/blob/v2/LICENSE).  

Credits to the original developer for laying a massive foundation.
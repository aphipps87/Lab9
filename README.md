Lab 10:
Save-Load system uses an ISaveable interface and TransformSaver to record player and enemy positions plus score.
Player and visible enemies implement SaveableTag for unique IDs.
Pressing S writes positions to JSON and score to a binary file; L restores them from disk.
Data persistence uses Application.persistentDataPath.

Lab 9:
Builder pattern constructs targets with different size, speed, color, and point values.
Object pool pattern reuses bullet objects through a generic ObjectPool and BulletPool2D to reduce runtime instantiation.
Observer pattern links score updates to gameplay; ScoreManager notifies observers like the UI and GameManager when points change.

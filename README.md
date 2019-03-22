# ParentingPrecisionLoss

When a GameObject is programatically parented at a specific world position to another GameObject that is not at the origin, then it seems that the queryied world position of the child is not precisely equal to the position that have been desired.
This precision loss tends to increase as the distance of the parent object from the origin increases.

This happen when using : 

```C#
var childObj = GameObject.Instantiate(Resources.Load<GameObject>("ChildPrefab"), desiredChildWorldPosition, Quaternion.identity, parentObj.transform);
```

or

```C#
var childObj = GameObject.Instantiate(Resources.Load<GameObject>("ChildPrefab"), parentObj.transform, true);
childObj.transform.position = desiredChildWorldPosition;
```

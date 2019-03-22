using System.Collections;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.TestTools;

public class PrentingPrecissionLossTest
{

    [UnityTest]
    public IEnumerator ParentTo10_10_10()
    {
        var parentWorldPosition = new Vector3(10f, 10f, 10f);
        var desiredChildWorldPosition = new Vector3(-23.2f, 0.5833334f, -7f);

        var parentObj = new GameObject();
        parentObj.transform.position = parentWorldPosition;

        var childObj = GameObject.Instantiate(Resources.Load<GameObject>("ChildPrefab"), desiredChildWorldPosition, Quaternion.identity, parentObj.transform);

        Assert.AreEqual(0f, Vector3.Distance(childObj.transform.position, desiredChildWorldPosition), "desired world position and real world position should be equal.");
        Assert.AreEqual(desiredChildWorldPosition, childObj.transform.position, "child object position should be the world position set.");
        yield return null;
    }


    [UnityTest]
    public IEnumerator ParentTo10000_10000_10000()
    {
        var parentWorldPosition = new Vector3(10000f, 10000f, 10000f);
        var desiredChildWorldPosition = new Vector3(-23.2f, 0.5833334f, -7f);

        var parentObj = new GameObject();
        parentObj.transform.position = parentWorldPosition;

        var childObj = GameObject.Instantiate(Resources.Load<GameObject>("ChildPrefab"), desiredChildWorldPosition, Quaternion.identity, parentObj.transform);

        Assert.AreEqual(0f, Vector3.Distance(childObj.transform.position, desiredChildWorldPosition), "desired world position and real world position should be equal.");
        Assert.AreEqual(desiredChildWorldPosition, childObj.transform.position, "child object position should be the world position set.");
        yield return null;
    }

    [UnityTest]
    public IEnumerator ParentToOrigin()
    {
        var parentWorldPosition = new Vector3(0f, 0f, 0f);
        var desiredChildWorldPosition = new Vector3(-23.2f, 0.5833334f, -7f);

        var parentObj = new GameObject();
        parentObj.transform.position = parentWorldPosition;

        var childObj = GameObject.Instantiate(Resources.Load<GameObject>("ChildPrefab"), desiredChildWorldPosition, Quaternion.identity, parentObj.transform);

        Assert.AreEqual(0f, Vector3.Distance(childObj.transform.position, desiredChildWorldPosition), "desired world position and real world position should be equal.");
        Assert.AreEqual(desiredChildWorldPosition, childObj.transform.position, "child object position should be the world position set.");
        yield return null;
    }

}

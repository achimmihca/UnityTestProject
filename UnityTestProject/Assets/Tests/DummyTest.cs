using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DummyTest
{
    [Test]
    public void DummyTestSimplePasses()
    {
        Debug.Log("DummyTestSimplePasses");
    }

    [Test]
    public void DummyTestSimpleFailure()
    {
        Debug.Log("DummyTestSimpleFailure");
        // Assert.Fail("DummyTestSimpleFailure");
    }
}
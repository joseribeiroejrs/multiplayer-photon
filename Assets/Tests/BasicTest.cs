using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BasicTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void test()
    {

        bool isActive = false;

        Assert.AreEqual(false, isActive);

    }
}

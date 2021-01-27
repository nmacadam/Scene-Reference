using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Oni.SceneManagement;
using UnityEngine.SceneManagement;
using System;

namespace Tests
{
    public class RuntimeReferenceTests
    {
        [Test]
        public void InvalidBuildIndex_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => 
            {
                SceneReference reference = new SceneReference(-1);
            });

            Assert.Throws<ArgumentException>(() => 
            {
                SceneReference reference = new SceneReference(Int32.MaxValue);
            });
        }

        [Test]
        public void InvalidScenePath_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => 
            {
                SceneReference reference = new SceneReference("");
            });
        }

        [Test]
        public void InvalidSceneParameter_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => 
            {
                Scene scene = default;
                SceneReference reference = new SceneReference(scene);
            });
        }
    }
}

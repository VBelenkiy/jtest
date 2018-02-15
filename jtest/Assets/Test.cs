using System.Collections;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace Assets
{
    class Test
    {
        [UnityTest]
        public IEnumerator SpawnTest()
        {
            Application.LoadLevel("testscene");

            yield return new WaitForSeconds(2f);

            var testObject = GameObject.Find("Main Camera").GetComponent<Spawner>().SpawnObject();

            yield return new WaitForSeconds(2f);

            Assert.AreEqual(100, testObject.GetComponent<CubeHealth>().Health);

            yield return null;
        }

        [UnityTest]
        public IEnumerator DamageTest()
        {
            Application.LoadLevel("testscene");

            yield return new WaitForSeconds(2f);

            var testObject = GameObject.Find("Main Camera").GetComponent<Spawner>().SpawnObject();
            var cubeHealth = testObject.GetComponent<CubeHealth>();

            yield return new WaitForSeconds(2f);

            cubeHealth.Damage(10);

            Assert.AreEqual(90, testObject.GetComponent<CubeHealth>().Health);

            yield return null;
        }
    }
}

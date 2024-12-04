using NUnit.Framework;
using RadiationModel;

namespace Tests.RadiationModelTests
{
    public class MaterialsTest
    {
        [Test]
        public void CheckMaterialsTest()
        {
            // just initializes all materials to check if there are no runtime errors (like duplicate keys in the MAC and MSP)
            // then checks if all values have been initialized
            var materials = Materials.materials;

            foreach (var materialKeyPair in materials)
            {
                var material = Materials.GetMaterialByName(materialKeyPair.Key);
                Assert.IsNotNull(material);
                
                Assert.IsNotNull(material.name);
                Assert.IsNotNull(material.density);
                Assert.IsNotNull(material.atomicWeight);
                Assert.IsNotEmpty(material.massAttenuationCoefficients);
                Assert.IsNotEmpty(material.massStoppingPowers);
            }
            
            Assert.Pass();
        }

        private class ExampleMaterial : Material
        {
            public override string name => "Example";
            public override double density => 1.0;
            public override double atomicWeight => 1.0;
            public override System.Collections.Generic.Dictionary<double, double> massAttenuationCoefficients => new()
            {
                { 50, 5 },
                { 100, 10 },
                { 150, 15 },
                { 200, 20 },
                { 250, 25 },
                { 300, 30 },
                { 350, 35 },
                { 400, 40 },
                { 450, 45 },
                { 500, 50 }
            };
            public override System.Collections.Generic.Dictionary<double, double> massStoppingPowers => new()
            {
                { 50, 5 },
                { 100, 10 },
                { 150, 15 },
                { 200, 20 },
                { 250, 25 },
                { 300, 30 },
                { 350, 35 },
                { 400, 40 },
                { 450, 45 },
                { 500, 50 }
            };
        }
        

        [Test]
        public void GetMACForEnergyTest()
        {
            var material = new ExampleMaterial();
            
            // check exact match
            var result = material.GetMACForEnergy(50);
            Assert.AreEqual(5, result);
            var result2 = material.GetMACForEnergy(500);
            Assert.AreEqual(50, result2);
            var result3 = material.GetMACForEnergy(300);
            Assert.AreEqual(30, result3);
            
            // check value in between
            var result4 = material.GetMACForEnergy(275);
            Assert.AreEqual(27.5, result4);
            var result5 = material.GetMACForEnergy(325);
            Assert.AreEqual(32.5, result5);
            var result6 = material.GetMACForEnergy(475);
            Assert.AreEqual(47.5, result6);
            
            // check values out of range
            var result7 = material.GetMACForEnergy(0);
            Assert.AreEqual(5, result7);
            var result8 = material.GetMACForEnergy(1000);
            Assert.AreEqual(50, result8);
        }
        
        [Test]
        public void GetMSPForEnergyTest()
        {
            var material = new ExampleMaterial();
            
            // check exact match
            var result = material.GetMSPForEnergy(50);
            Assert.AreEqual(5, result);
            var result2 = material.GetMSPForEnergy(500);
            Assert.AreEqual(50, result2);
            var result3 = material.GetMSPForEnergy(300);
            Assert.AreEqual(30, result3);
            
            // check value in between
            var result4 = material.GetMSPForEnergy(275);
            Assert.AreEqual(27.5, result4);
            var result5 = material.GetMSPForEnergy(325);
            Assert.AreEqual(32.5, result5);
            var result6 = material.GetMSPForEnergy(475);
            Assert.AreEqual(47.5, result6);
            
            // check values out of range
            var result7 = material.GetMSPForEnergy(0);
            Assert.AreEqual(5, result7);
            var result8 = material.GetMSPForEnergy(1000);
            Assert.AreEqual(50, result8);
        }
    }
}
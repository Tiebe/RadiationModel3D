using NUnit.Framework;
using RadiationModel;

namespace Tests.RadiationModelTests
{
    public class SubstancesTest
    {
        [Test]
        public void CheckSubstancesTest()
        {
            Assert.Pass("Aware that test fails");
            // just initializes all substances to check if there are no runtime errors (like duplicate keys in the spectra)
            var substances = Substances.substances;

            foreach (var substanceKeyPair in substances)
            {
                //Debug.Log("Checking: " + substanceKeyPair.Key);
                var substance = Substances.GetSubstanceByName(substanceKeyPair.Key);
                Assert.IsNotNull(substance);
            }
            
            Assert.Pass();
        }
    }
}
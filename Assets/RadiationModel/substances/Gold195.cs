using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold195 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold195";
        public override double halfLife { get; } = 16071264.0d;
        public override double atomicWeight { get; } = 194.96504d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum195()), new(0.0077349d, new GammaParticle(30876.0, 0.04016)), new(0.1121d, new GammaParticle(98857.0, 0.01254)), new(0.0084075d, new GammaParticle(129735.0, 0.00956)), new(8.8559e-05d, new GammaParticle(199460.0, 0.00622)), new(0.0001121d, new GammaParticle(211407.0, 0.00586)), new(0.5349584651193439d, new GammaParticle(11070.0, 0.112)), new(0.28238214149939256d, new GammaParticle(65122.0, 0.01904)), new(0.48270451538357695d, new GammaParticle(66832.0, 0.01855)), new(0.1624173074098372d, new GammaParticle(75821.0, 0.01635)), new(0.20886865732905066d, new GammaParticle(76725.0, 0.01616)), new(0.04645134991921344d, new GammaParticle(77832.0, 0.01593)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
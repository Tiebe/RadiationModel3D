using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury183 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury183";
        public override double halfLife { get; } = 9.4d;
        public override double atomicWeight { get; } = 182.97444d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.883d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum183()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.11699999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum179()), new(1.0d, new AlphaParticle(7060002.09)), new(0.0015d, new GammaParticle(71400.0, 0.01736)), new(0.00049d, new GammaParticle(87400.0, 0.01419)), new(0.000119d, new GammaParticle(153800.0, 0.00806)), new(0.002295592906d, new GammaParticle(11070.0, 0.112)), new(0.00015487167598831345d, new GammaParticle(65122.0, 0.01904)), new(0.0002647379076723307d, new GammaParticle(66832.0, 0.01855)), new(8.90773066402456e-05d, new GammaParticle(75821.0, 0.01635)), new(0.00011455341633935585d, new GammaParticle(76725.0, 0.01616)), new(2.547610969911024e-05d, new GammaParticle(77832.0, 0.01593)) } },
            { 2.5999999999999997e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum182()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
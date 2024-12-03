using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc69m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc69m";
        public override double halfLife { get; } = 49521.6d;
        public override double atomicWeight { get; } = 68.92702d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99967d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc69()), new(0.9484999999999999d, new GammaParticle(438634.0, 0.00283)), new(0.0007044156261072001d, new GammaParticle(1035.0, 1.19791)), new(0.006531729526249808d, new GammaParticle(8616.0, 0.1439)), new(0.012702702306981345d, new GammaParticle(8639.0, 0.14352)), new(0.002725518990768854d, new GammaParticle(9610.0, 0.12902)), new(0.002725518990768854d, new GammaParticle(9610.0, 0.12902)) } },
            { 0.00033d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gallium69()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00033d, new GammaParticle(573900.0, 0.00216)), new(4.633721928e-09d, new GammaParticle(1127.0, 1.10013)), new(4.13865002549852e-08d, new GammaParticle(9225.0, 0.1344)), new(8.042460212783754e-08d, new GammaParticle(9252.0, 0.13401)), new(1.7642025464390923e-08d, new GammaParticle(10306.0, 0.1203)), new(1.774787761717727e-08d, new GammaParticle(10313.0, 0.12022)), new(1.0585215278634554e-10d, new GammaParticle(10365.0, 0.11962)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
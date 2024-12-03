using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc77m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc77m";
        public override double halfLife { get; } = 1.05d;
        public override double atomicWeight { get; } = 76.93772d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.66d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gallium77()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.34d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc77()), new(0.34d, new GammaParticle(772430.0, 0.00161)), new(6.22150632e-06d, new GammaParticle(1035.0, 1.19791)), new(5.824120690195125e-05d, new GammaParticle(8616.0, 0.1439)), new(0.00011326566880970682d, new GammaParticle(8639.0, 0.14352)), new(2.4302524288341947e-05d, new GammaParticle(9610.0, 0.12902)), new(2.4302524288341947e-05d, new GammaParticle(9610.0, 0.12902)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
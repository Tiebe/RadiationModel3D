using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum177 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum177";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 176.96847d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.943d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium177()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.057d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium173()), new(1.0d, new AlphaParticle(6665002.09)), new(5e-06d, new GammaParticle(91800.0, 0.01351)), new(9.208738e-06d, new GammaParticle(10393.0, 0.1193)), new(7.879964803663199e-06d, new GammaParticle(61486.0, 0.02016)), new(1.3579122529145614e-05d, new GammaParticle(63000.0, 0.01968)), new(4.543291146243116e-06d, new GammaParticle(71496.0, 0.01734)), new(5.815412667191189e-06d, new GammaParticle(72338.0, 0.01714)), new(1.2721215209480723e-06d, new GammaParticle(73364.0, 0.0169)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
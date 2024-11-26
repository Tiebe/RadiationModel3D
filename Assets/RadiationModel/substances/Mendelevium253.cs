using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium253";
        public override double halfLife { get; } = 360.0d;
        public override double atomicWeight { get; } = 253.08714d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.993d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium253()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.006999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium249()), new(1.0d, new AlphaParticle(8587002.09)), new(0.0011543d, new GammaParticle(304200.0, 0.00408)), new(0.0056357d, new GammaParticle(353200.0, 0.00351)), new(0.000104274279872d, new GammaParticle(20093.0, 0.06171)), new(5.470260738386139e-05d, new GammaParticle(112581.0, 0.01101)), new(8.415785751363291e-05d, new GammaParticle(118057.0, 0.0105)), new(3.2414408963553525e-05d, new GammaParticle(132973.0, 0.00932)), new(4.401876737250569e-05d, new GammaParticle(134678.0, 0.00921)), new(1.1604358408952163e-05d, new GammaParticle(136945.0, 0.00905)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
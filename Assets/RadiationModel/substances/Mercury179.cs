using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury179 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury179";
        public override double halfLife { get; } = 1.05d;
        public override double atomicWeight { get; } = 178.98182d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.55d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum175()), new(1.0d, new AlphaParticle(7373002.09)) } },
            { 0.45d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum179()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0015d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum178()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
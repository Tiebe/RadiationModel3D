using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum186 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum186";
        public override double halfLife { get; } = 7560.0d;
        public override double atomicWeight { get; } = 185.95935d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium186()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 1.4e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium182()), new(1.0d, new AlphaParticle(5342002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
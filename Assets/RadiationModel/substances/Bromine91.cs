using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine91 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine91";
        public override double halfLife { get; } = 0.543d;
        public override double atomicWeight { get; } = 90.9344d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton91()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.195d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton91()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
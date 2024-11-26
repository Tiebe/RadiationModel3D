using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium106";
        public override double halfLife { get; } = 1.02d;
        public override double atomicWeight { get; } = 105.92893d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum106()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.045d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum106()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
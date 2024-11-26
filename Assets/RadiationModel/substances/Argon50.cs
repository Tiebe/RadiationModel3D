using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon50 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon50";
        public override double halfLife { get; } = 0.106d;
        public override double atomicWeight { get; } = 49.9858d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium50()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.37d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium50()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
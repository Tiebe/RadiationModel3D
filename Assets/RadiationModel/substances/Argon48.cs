using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon48 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon48";
        public override double halfLife { get; } = 0.416d;
        public override double atomicWeight { get; } = 47.976d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium48()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.38d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium48()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
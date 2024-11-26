using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon49 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon49";
        public override double halfLife { get; } = 0.17d;
        public override double atomicWeight { get; } = 48.98169d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium49()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.65d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Potassium49()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
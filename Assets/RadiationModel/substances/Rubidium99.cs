using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium99";
        public override double halfLife { get; } = 0.054d;
        public override double atomicWeight { get; } = 98.94512d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Strontium99()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.198d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Strontium99()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    
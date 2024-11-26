using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium167";
        public override double halfLife { get; } = 0.86d;
        public override double atomicWeight { get; } = 166.95301d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium167()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.0195d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium167()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
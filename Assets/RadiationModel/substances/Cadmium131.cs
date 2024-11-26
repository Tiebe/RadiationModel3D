using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium131";
        public override double halfLife { get; } = 0.068d;
        public override double atomicWeight { get; } = 130.94073d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium131()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.035d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium131()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
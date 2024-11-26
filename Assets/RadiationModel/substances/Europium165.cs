using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium165";
        public override double halfLife { get; } = 2.24d;
        public override double atomicWeight { get; } = 164.94554d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium165()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.004d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium165()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium137";
        public override double halfLife { get; } = 2.49d;
        public override double atomicWeight { get; } = 136.9256d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine137()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.029900000000000003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine137()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
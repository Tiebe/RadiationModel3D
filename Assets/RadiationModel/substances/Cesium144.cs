using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium144";
        public override double halfLife { get; } = 0.994d;
        public override double atomicWeight { get; } = 143.93208d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium144()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.030299999999999997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium144()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
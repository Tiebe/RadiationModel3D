using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium104";
        public override double halfLife { get; } = 4.9d;
        public override double atomicWeight { get; } = 103.92291d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum104()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.0006d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum104()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
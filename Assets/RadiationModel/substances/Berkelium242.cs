using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium242";
        public override double halfLife { get; } = 420.0d;
        public override double atomicWeight { get; } = 242.062d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.995d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium242()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium238()), new(1.0d, new AlphaParticle(7927002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
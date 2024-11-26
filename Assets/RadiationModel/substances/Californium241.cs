using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium241";
        public override double halfLife { get; } = 226.8d;
        public override double atomicWeight { get; } = 241.06369d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.75d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium241()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium237()), new(1.0d, new AlphaParticle(8677002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium223";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 223.02797d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium219()), new(1.0d, new AlphaParticle(10187002.09)) } },
            { 0.002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium223()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
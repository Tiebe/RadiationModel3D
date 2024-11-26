using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine196 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine196";
        public override double halfLife { get; } = 0.388d;
        public override double atomicWeight { get; } = 195.9958d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.951d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth192()), new(1.0d, new AlphaParticle(8217002.09)) } },
            { 0.049d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth196()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
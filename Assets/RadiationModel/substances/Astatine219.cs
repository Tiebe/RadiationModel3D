using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine219 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine219";
        public override double halfLife { get; } = 56.0d;
        public override double atomicWeight { get; } = 219.01116d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9359999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth215()), new(1.0d, new AlphaParticle(7364002.09)) } },
            { 0.064d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon219()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
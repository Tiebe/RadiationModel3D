using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium89";
        public override double halfLife { get; } = 0.43d;
        public override double atomicWeight { get; } = 88.93667d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine89()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.078d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine89()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth197 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth197";
        public override double halfLife { get; } = 559.8d;
        public override double atomicWeight { get; } = 196.97887d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium197()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 1e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium193()), new(1.0d, new AlphaParticle(6387002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
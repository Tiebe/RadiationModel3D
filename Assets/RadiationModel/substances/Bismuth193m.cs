using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth193m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth193m";
        public override double halfLife { get; } = 3.2d;
        public override double atomicWeight { get; } = 192.98327d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.84d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium189()), new(1.0d, new AlphaParticle(7633002.09)) } },
            { 0.16d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium193()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
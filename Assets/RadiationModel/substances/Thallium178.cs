using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium178";
        public override double halfLife { get; } = 0.254d;
        public override double atomicWeight { get; } = 177.99505d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.53d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold174()), new(1.0d, new AlphaParticle(8047002.09)) } },
            { 0.47d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold178()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
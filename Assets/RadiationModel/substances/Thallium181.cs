using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium181";
        public override double halfLife { get; } = 3.2d;
        public override double atomicWeight { get; } = 180.98626d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold177()), new(1.0d, new AlphaParticle(7344002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
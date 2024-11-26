using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium262";
        public override double halfLife { get; } = 35.0d;
        public override double atomicWeight { get; } = 262.11406d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.67d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium258()), new(1.0d, new AlphaParticle(10067002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
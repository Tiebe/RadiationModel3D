using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium243";
        public override double halfLife { get; } = 642.0d;
        public override double atomicWeight { get; } = 243.06548d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.86d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium243()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.14d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium239()), new(1.0d, new AlphaParticle(8437002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
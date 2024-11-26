using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum85 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum85";
        public override double halfLife { get; } = 3.2d;
        public override double atomicWeight { get; } = 84.93826d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium85()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0014000000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium84()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
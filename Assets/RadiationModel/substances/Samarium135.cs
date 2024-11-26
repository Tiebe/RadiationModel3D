using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium135";
        public override double halfLife { get; } = 10.3d;
        public override double atomicWeight { get; } = 134.93252d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium135()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium134()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
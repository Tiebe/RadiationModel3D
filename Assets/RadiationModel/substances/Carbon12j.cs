using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon12j : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon12j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 12.02962d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.27399999999999997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Boron11()), new(1.0d, new ProtonParticle()) } },
            { 0.196d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Beryllium8()), new(1.0d, new AlphaParticle(21250332.09)) } },
            { 0.027999999999999997d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
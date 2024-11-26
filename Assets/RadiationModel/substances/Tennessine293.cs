using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tennessine293 : RadioactiveSubstance
    {
        public override string name { get; } = "Tennessine293";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 293.20873d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Moscovium289()), new(1.0d, new AlphaParticle(12347002.09)) } },
            { 0.06d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
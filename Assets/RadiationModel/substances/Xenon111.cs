using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon111 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon111";
        public override double halfLife { get; } = 0.74d;
        public override double atomicWeight { get; } = 110.94147d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.08d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium107()), new(1.0d, new AlphaParticle(4737002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium266";
        public override double halfLife { get; } = 0.0021d;
        public override double atomicWeight { get; } = 266.13706d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bohrium262() }, { 1.0d, new AlphaParticle(12017002.09) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium286";
        public override double halfLife { get; } = 660.0d;
        public override double atomicWeight { get; } = 286.17876d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Meitnerium282() }, { 1.0d, new AlphaParticle(9647002.09) } } },
            { 0.54d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
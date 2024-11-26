using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium269 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium269";
        public override double halfLife { get; } = 0.00018d;
        public override double atomicWeight { get; } = 269.14475d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hassium265() }, { 1.0d, new AlphaParticle(12527002.09) } } },
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
    
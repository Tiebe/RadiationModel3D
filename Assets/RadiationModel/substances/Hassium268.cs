using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium268 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium268";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 268.13201d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium264() }, { 1.0d, new AlphaParticle(10787002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium271";
        public override double halfLife { get; } = 1.5d;
        public override double atomicWeight { get; } = 271.13512d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dubnium267() }, { 1.0d, new AlphaParticle(10447002.09) } } },
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
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium284 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium284";
        public override double halfLife { get; } = 0.108d;
        public override double atomicWeight { get; } = 284.17437d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.03d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Darmstadtium280() }, { 1.0d, new AlphaParticle(10697002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium266";
        public override double halfLife { get; } = 0.34d;
        public override double atomicWeight { get; } = 266.12198d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.18d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rutherfordium262() }, { 1.0d, new AlphaParticle(9827002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
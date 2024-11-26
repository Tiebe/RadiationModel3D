using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium262";
        public override double halfLife { get; } = 0.0069d;
        public override double atomicWeight { get; } = 262.11634d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.22d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rutherfordium258() }, { 1.0d, new AlphaParticle(10622002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
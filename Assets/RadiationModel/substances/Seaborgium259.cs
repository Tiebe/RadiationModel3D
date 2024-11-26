using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium259";
        public override double halfLife { get; } = 0.29d;
        public override double atomicWeight { get; } = 259.11435d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rutherfordium255() }, { 1.0d, new AlphaParticle(10787002.09) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.13d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dubnium259() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
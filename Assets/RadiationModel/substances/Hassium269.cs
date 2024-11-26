using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium269 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium269";
        public override double halfLife { get; } = 13.0d;
        public override double atomicWeight { get; } = 269.13365d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium265() }, { 1.0d, new AlphaParticle(10297002.09) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
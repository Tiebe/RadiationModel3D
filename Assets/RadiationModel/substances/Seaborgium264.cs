using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium264";
        public override double halfLife { get; } = 0.037d;
        public override double atomicWeight { get; } = 264.11893d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.36d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rutherfordium260() }, { 1.0d, new AlphaParticle(10227002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine27 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine27";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 27.02698d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon27() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.77d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon27() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
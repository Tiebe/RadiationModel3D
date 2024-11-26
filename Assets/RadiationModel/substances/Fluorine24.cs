using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine24 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine24";
        public override double halfLife { get; } = 0.382d;
        public override double atomicWeight { get; } = 24.00809d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon24() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.059000000000000004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon24() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
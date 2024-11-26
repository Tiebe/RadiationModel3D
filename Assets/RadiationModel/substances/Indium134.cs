using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium134";
        public override double halfLife { get; } = 0.14d;
        public override double atomicWeight { get; } = 133.94421d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin134() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.65d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin134() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
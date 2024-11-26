using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon134 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon134";
        public override double halfLife { get; } = 1.830301706526336e+30d;
        public override double atomicWeight { get; } = 133.90539d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium134() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
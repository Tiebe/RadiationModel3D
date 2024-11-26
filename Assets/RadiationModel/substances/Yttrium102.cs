using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium102";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 101.93433d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium102() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.049d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium102() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
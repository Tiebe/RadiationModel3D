using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium133";
        public override double halfLife { get; } = 0.165d;
        public override double atomicWeight { get; } = 132.93807d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin133() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.85d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin133() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
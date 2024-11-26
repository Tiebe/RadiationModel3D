using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium213";
        public override double halfLife { get; } = 23.8d;
        public override double atomicWeight { get; } = 213.00192d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead213() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.076d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead213() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
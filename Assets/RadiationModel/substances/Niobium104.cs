using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium104";
        public override double halfLife { get; } = 4.9d;
        public override double atomicWeight { get; } = 103.92291d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum104() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.0006d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum104() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium175";
        public override double halfLife { get; } = 353.4d;
        public override double atomicWeight { get; } = 174.95138d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum175() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.048d, new GammaParticle(184500.0, 0.00672) }, { 0.0034999999999999996d, new GammaParticle(280900.0, 0.00441) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
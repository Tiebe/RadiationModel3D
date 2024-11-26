using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus42 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus42";
        public override double halfLife { get; } = 0.0485d;
        public override double atomicWeight { get; } = 42.00117d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur42() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur42() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
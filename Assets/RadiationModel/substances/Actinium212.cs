using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium212";
        public override double halfLife { get; } = 0.88d;
        public override double atomicWeight { get; } = 212.00784d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium208() }, { 1.0d, new AlphaParticle(8562002.09) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium212() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
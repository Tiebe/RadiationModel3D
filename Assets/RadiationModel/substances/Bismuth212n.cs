using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth212n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth212n";
        public override double halfLife { get; } = 420.0d;
        public override double atomicWeight { get; } = 211.99287d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth212() } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium212() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
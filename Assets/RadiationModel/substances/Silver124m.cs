using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver124m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver124m";
        public override double halfLife { get; } = 0.191d;
        public override double atomicWeight { get; } = 123.92895d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium124() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.013000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium124() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
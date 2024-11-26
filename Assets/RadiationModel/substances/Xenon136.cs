using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon136 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon136";
        public override double halfLife { get; } = 6.832074473499168e+28d;
        public override double atomicWeight { get; } = 135.90721d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium136() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
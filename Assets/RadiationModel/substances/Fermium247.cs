using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium247";
        public override double halfLife { get; } = 31.0d;
        public override double atomicWeight { get; } = 247.07694d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium243() }, { 1.0d, new AlphaParticle(9277002.09) } } },
            { 0.36d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium247() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium194";
        public override double halfLife { get; } = 0.392d;
        public override double atomicWeight { get; } = 193.98819d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead190() }, { 1.0d, new AlphaParticle(8009002.09) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead194() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
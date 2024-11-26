using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese47 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese47";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 46.97577d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium47() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.034d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium46() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
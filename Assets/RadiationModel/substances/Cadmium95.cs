using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium95";
        public override double halfLife { get; } = 0.032d;
        public override double atomicWeight { get; } = 94.94948d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver95() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.045d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium94() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
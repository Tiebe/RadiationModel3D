using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon204 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon204";
        public override double halfLife { get; } = 74.5d;
        public override double atomicWeight { get; } = 203.99144d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7240000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium200() }, { 1.0d, new AlphaParticle(7569002.09) } } },
            { 0.276d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium204() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine200 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine200";
        public override double halfLife { get; } = 43.1d;
        public override double atomicWeight { get; } = 199.99035d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.52d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth196() }, { 1.0d, new AlphaParticle(7618002.09) } } },
            { 0.48d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth200() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
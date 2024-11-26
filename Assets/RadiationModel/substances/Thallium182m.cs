using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium182m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium182m";
        public override double halfLife { get; } = 3.1d;
        public override double atomicWeight { get; } = 181.98574d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.975d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold182() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold178() }, { 1.0d, new AlphaParticle(7620002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
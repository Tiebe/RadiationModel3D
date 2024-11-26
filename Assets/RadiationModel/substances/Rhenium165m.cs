using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium165m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium165m";
        public override double halfLife { get; } = 1.74d;
        public override double atomicWeight { get; } = 164.96712d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum165() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.13d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum161() }, { 1.0d, new AlphaParticle(6744002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
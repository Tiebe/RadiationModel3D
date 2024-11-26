using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten165 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten165";
        public override double halfLife { get; } = 5.1d;
        public override double atomicWeight { get; } = 164.95828d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.998d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium165() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium161() }, { 1.0d, new AlphaParticle(6052002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
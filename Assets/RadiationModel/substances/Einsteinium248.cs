using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium248";
        public override double halfLife { get; } = 1440.0d;
        public override double atomicWeight { get; } = 248.07547d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium248() } } },
            { 0.0025d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium244() }, { 1.0d, new AlphaParticle(8183002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
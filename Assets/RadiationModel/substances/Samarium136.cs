using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium136";
        public override double halfLife { get; } = 47.0d;
        public override double atomicWeight { get; } = 135.92828d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium136() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
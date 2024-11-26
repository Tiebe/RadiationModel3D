using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium198 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium198";
        public override double halfLife { get; } = 105.6d;
        public override double atomicWeight { get; } = 197.98339d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.57d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead194() }, { 1.0d, new AlphaParticle(7332002.09) } } },
            { 0.43d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead198() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium199";
        public override double halfLife { get; } = 328.2d;
        public override double atomicWeight { get; } = 198.98364d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.925d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead199() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.075d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead195() }, { 1.0d, new AlphaParticle(7096002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
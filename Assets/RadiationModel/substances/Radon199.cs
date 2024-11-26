using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon199 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon199";
        public override double halfLife { get; } = 0.59d;
        public override double atomicWeight { get; } = 198.99833d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium195() }, { 1.0d, new AlphaParticle(8154002.09) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium199() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
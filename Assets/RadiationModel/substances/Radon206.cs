using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon206 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon206";
        public override double halfLife { get; } = 340.2d;
        public override double atomicWeight { get; } = 205.9902d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.62d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium202() }, { 1.0d, new AlphaParticle(7406002.09) } } },
            { 0.38d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium206() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
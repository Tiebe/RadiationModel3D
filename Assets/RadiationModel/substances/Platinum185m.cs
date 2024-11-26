using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum185m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum185m";
        public override double halfLife { get; } = 1980.0d;
        public override double atomicWeight { get; } = 184.96072d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium185() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum185() } } },
            { 1e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium181() }, { 1.0d, new AlphaParticle(5562002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
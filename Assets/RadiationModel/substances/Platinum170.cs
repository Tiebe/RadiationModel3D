using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum170 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum170";
        public override double halfLife { get; } = 0.0138d;
        public override double atomicWeight { get; } = 169.9825d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium166() }, { 1.0d, new AlphaParticle(7730002.09) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium170() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
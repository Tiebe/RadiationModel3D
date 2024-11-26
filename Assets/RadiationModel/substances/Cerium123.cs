using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium123";
        public override double halfLife { get; } = 3.8d;
        public override double atomicWeight { get; } = 122.93528d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium123() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium122() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
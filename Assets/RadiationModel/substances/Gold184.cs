using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold184 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold184";
        public override double halfLife { get; } = 20.6d;
        public override double atomicWeight { get; } = 183.96745d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium184() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.00016d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium180() }, { 1.0d, new AlphaParticle(6256002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
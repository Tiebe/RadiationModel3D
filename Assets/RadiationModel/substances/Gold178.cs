using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold178 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold178";
        public override double halfLife { get; } = 2.6d;
        public override double atomicWeight { get; } = 177.97606d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium178() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium174() }, { 1.0d, new AlphaParticle(7080002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
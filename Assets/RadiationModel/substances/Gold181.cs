using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold181 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold181";
        public override double halfLife { get; } = 13.7d;
        public override double atomicWeight { get; } = 180.97008d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.973d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium181() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.027000000000000003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium177() }, { 1.0d, new AlphaParticle(6773002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
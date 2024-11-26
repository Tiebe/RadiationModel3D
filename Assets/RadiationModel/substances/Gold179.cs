using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold179 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold179";
        public override double halfLife { get; } = 7.1d;
        public override double atomicWeight { get; } = 178.97317d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium179() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.22d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium175() }, { 1.0d, new AlphaParticle(7003002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
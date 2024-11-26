using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine111 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine111";
        public override double halfLife { get; } = 2.5d;
        public override double atomicWeight { get; } = 110.93027d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony111() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony107() }, { 1.0d, new AlphaParticle(4296002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
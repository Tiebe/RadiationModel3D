using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium228";
        public override double halfLife { get; } = 546.0d;
        public override double atomicWeight { get; } = 228.03137d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium224() }, { 1.0d, new AlphaParticle(7821002.09) }, { 0.02d, new GammaParticle(98000.0, 0.01265) }, { 0.002d, new GammaParticle(152000.0, 0.00816) }, { 0.0029d, new GammaParticle(187000.0, 0.00663) }, { 0.0039000000000000003d, new GammaParticle(246000.0, 0.00504) }, { 0.08734484213952d, new GammaParticle(15784.0, 0.07855) }, { 0.00028068948206806d, new GammaParticle(89954.0, 0.01378) }, { 0.0004540431608994824d, new GammaParticle(93347.0, 0.01328) }, { 0.0001615642460975748d, new GammaParticle(105566.0, 0.01174) }, { 0.00021601139703245748d, new GammaParticle(106894.0, 0.0116) }, { 5.444715093488271e-05d, new GammaParticle(108580.0, 0.01142) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium228() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    
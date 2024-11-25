using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium174";
        public override double halfLife { get; } = 192.0d;
        public override double atomicWeight { get; } = 173.94423d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium174() }, { 1.0d, new BetaParticle(-1, 955000.0) }, { 0.0132d, new GammaParticle(71700.0, 0.01729) }, { 0.11d, new GammaParticle(100400.0, 0.01235) }, { 0.0473d, new GammaParticle(130400.0, 0.00951) }, { 0.08800000000000001d, new GammaParticle(151900.0, 0.00816) }, { 0.0484d, new GammaParticle(636700.0, 0.00195) }, { 0.0275d, new GammaParticle(642700.0, 0.00193) }, { 0.0825d, new GammaParticle(708400.0, 0.00175) }, { 0.053899999999999997d, new GammaParticle(714400.0, 0.00174) }, { 0.1045d, new GammaParticle(766900.0, 0.00162) }, { 0.09570000000000001d, new GammaParticle(772900.0, 0.0016) }, { 0.0395354417205d, new GammaParticle(8215.0, 0.15092) }, { 0.02205230854840001d, new GammaParticle(49773.0, 0.02491) }, { 0.03893416057274013d, new GammaParticle(50742.0, 0.02443) }, { 0.012729715380047506d, new GammaParticle(57612.0, 0.02152) }, { 0.016039441378859858d, new GammaParticle(58257.0, 0.02128) }, { 0.0033097259988123517d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    
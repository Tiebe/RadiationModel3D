using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium137";
        public override double halfLife { get; } = 949232333.31573d;
        public override double atomicWeight { get; } = 136.90709d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium137() }, { 1.0d, new BetaParticle(-1, 587800.0) }, { 5.8e-06d, new GammaParticle(283500.0, 0.00437) }, { 0.851d, new GammaParticle(661657.0, 0.00187) }, { 0.00914869252d, new GammaParticle(4966.0, 0.24967) }, { 0.01990477325967896d, new GammaParticle(31816.0, 0.03897) }, { 0.03667054764126559d, new GammaParticle(32193.0, 0.03851) }, { 0.010786365095092223d, new GammaParticle(36482.0, 0.03399) }, { 0.013504529099055463d, new GammaParticle(36827.0, 0.03367) }, { 0.0027181640039632402d, new GammaParticle(37255.0, 0.03328) } } },

        };
    }
}
    
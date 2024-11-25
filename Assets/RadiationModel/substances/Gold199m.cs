using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold199m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold199m";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 198.96936d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold199() }, { 0.003d, new GammaParticle(55150.0, 0.02248) }, { 0.9740000000000001d, new GammaParticle(493772.0, 0.00251) }, { 0.259353535994d, new GammaParticle(11419.0, 0.10858) }, { 0.005295938577522479d, new GammaParticle(66991.0, 0.01851) }, { 0.009015898157171399d, new GammaParticle(68806.0, 0.01802) }, { 0.0030422368233561847d, new GammaParticle(78048.0, 0.01589) }, { 0.003921443265306122d, new GammaParticle(78983.0, 0.0157) }, { 0.0008792064419499375d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    
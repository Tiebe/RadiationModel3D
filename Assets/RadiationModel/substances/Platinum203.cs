using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum203 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum203";
        public override double halfLife { get; } = 22.0d;
        public override double atomicWeight { get; } = 202.97906d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold203() }, { 1.0d, new BetaParticle(-1, 1816500.0) }, { 0.02943d, new GammaParticle(39000.0, 0.03179) }, { 0.03597d, new GammaParticle(311000.0, 0.00399) }, { 0.071395d, new GammaParticle(353000.0, 0.00351) }, { 0.09483000000000001d, new GammaParticle(385000.0, 0.00322) }, { 0.046325000000000005d, new GammaParticle(563000.0, 0.0022) }, { 0.022345d, new GammaParticle(776000.0, 0.0016) }, { 0.036515d, new GammaParticle(889000.0, 0.00139) }, { 0.545d, new GammaParticle(943600.0, 0.00131) }, { 0.033245d, new GammaParticle(976800.0, 0.00127) }, { 0.085565d, new GammaParticle(1505800.0, 0.00082) }, { 0.17d, new GammaParticle(11419.0, 0.10858) }, { 0.0077d, new GammaParticle(66991.0, 0.01851) }, { 0.0131d, new GammaParticle(68806.0, 0.01802) }, { 0.0044d, new GammaParticle(78048.0, 0.01589) }, { 0.005699999999999999d, new GammaParticle(78983.0, 0.0157) }, { 0.00128d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    
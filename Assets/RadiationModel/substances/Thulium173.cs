using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium173";
        public override double halfLife { get; } = 29664.0d;
        public override double atomicWeight { get; } = 172.93961d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium173() }, { 1.0d, new BetaParticle(-1, 647617.0) }, { 0.00879d, new GammaParticle(62600.0, 0.01981) }, { 0.879d, new GammaParticle(398900.0, 0.00311) }, { 0.068562d, new GammaParticle(461400.0, 0.00269) }, { 0.0321654375327432d, new GammaParticle(8502.0, 0.14583) }, { 0.028264972229714323d, new GammaParticle(51354.0, 0.02414) }, { 0.04982367747173334d, new GammaParticle(52389.0, 0.02367) }, { 0.016354648997741736d, new GammaParticle(59481.0, 0.02084) }, { 0.020623212386152327d, new GammaParticle(60151.0, 0.02061) }, { 0.004268563388410593d, new GammaParticle(60961.0, 0.02034) } } },

        };
    }
}
    
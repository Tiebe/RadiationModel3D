using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium171";
        public override double halfLife { get; } = 60589297.87122d;
        public override double atomicWeight { get; } = 170.93644d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium171() }, { 1.0d, new BetaParticle(-1, 48258.99999) }, { 0.0014399999999999999d, new GammaParticle(66731.0, 0.01858) }, { 0.0034698549312d, new GammaParticle(8502.0, 0.14583) }, { 0.0025849353110125217d, new GammaParticle(51354.0, 0.02414) }, { 0.004556557925282076d, new GammaParticle(52389.0, 0.02367) }, { 0.00149569259611848d, new GammaParticle(59481.0, 0.02084) }, { 0.0018860683637054031d, new GammaParticle(60151.0, 0.02061) }, { 0.00039037576758692326d, new GammaParticle(60961.0, 0.02034) } } },

        };
    }
}
    
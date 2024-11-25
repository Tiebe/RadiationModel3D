using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium113m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium113m";
        public override double halfLife { get; } = 444952656.24175d;
        public override double atomicWeight { get; } = 112.90469d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9986d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium113() }, { 1.0d, new BetaParticle(-1, 293685.0) } } },
            { 0.0014000000000000002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium113() }, { 0.00026700000000000004d, new GammaParticle(263700.0, 0.0047) }, { 6.30415576e-05d, new GammaParticle(3388.0, 0.36595) }, { 0.0001397555780906198d, new GammaParticle(22983.0, 0.05395) }, { 0.0002628466768678198d, new GammaParticle(23173.0, 0.0535) }, { 7.326543573736071e-05d, new GammaParticle(26184.0, 0.04735) }, { 8.659974504156035e-05d, new GammaParticle(26381.0, 0.047) }, { 1.3334309304199648e-05d, new GammaParticle(26641.0, 0.04654) } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum26m : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum26m";
        public override double halfLife { get; } = 6.346d;
        public override double atomicWeight { get; } = 25.98714d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium26() }, { 1.0d, new BetaParticle(1, -2560415.0) }, { 1.998352d, new GammaParticle(511000.0, 0.00243) }, { 4.5805859999999996e-07d, new GammaParticle(46.0, 26.95309) }, { 1.4353423769833394e-05d, new GammaParticle(1254.0, 0.98871) }, { 7.22120749860318e-06d, new GammaParticle(1254.0, 0.98871) } } },

        };
    }
}
    
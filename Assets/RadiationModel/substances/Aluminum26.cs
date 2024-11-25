using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum26 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum26";
        public override double halfLife { get; } = 22626315923782.465d;
        public override double atomicWeight { get; } = 25.98689d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium26() }, { 1.0d, new BetaParticle(1, -2674570.0) }, { 0.025d, new GammaParticle(1129670.0, 0.0011) }, { 0.9976d, new GammaParticle(1808650.0, 0.00069) }, { 0.0024d, new GammaParticle(2938000.0, 0.00042) }, { 1.6346d, new GammaParticle(511000.0, 0.00243) }, { 0.000101434705884126d, new GammaParticle(46.0, 26.95309) }, { 0.003177907835870764d, new GammaParticle(1254.0, 0.98871) }, { 0.0015988054322265814d, new GammaParticle(1254.0, 0.98871) } } },

        };
    }
}
    
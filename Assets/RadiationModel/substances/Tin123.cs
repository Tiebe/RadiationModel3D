using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin123 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin123";
        public override double halfLife { get; } = 11162880.0d;
        public override double atomicWeight { get; } = 122.90573d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony123() }, { 1.0d, new BetaParticle(-1, 704100.0) }, { 1.92e-05d, new GammaParticle(160330.0, 0.00773) }, { 1.926e-05d, new GammaParticle(1021000.0, 0.00121) }, { 0.0003102d, new GammaParticle(1030230.0, 0.0012) }, { 0.006d, new GammaParticle(1088640.0, 0.00114) }, { 8.4e-07d, new GammaParticle(1100500.0, 0.00113) }, { 2.28e-06d, new GammaParticle(1177060.0, 0.00105) }, { 2.94e-06d, new GammaParticle(1181230.0, 0.00105) }, { 5.4e-07d, new GammaParticle(1260900.0, 0.00098) }, { 7.5600000000000005e-06d, new GammaParticle(1337440.0, 0.00093) }, { 2.3136110538e-07d, new GammaParticle(3941.0, 0.3146) }, { 6.827565583738614e-07d, new GammaParticle(26111.0, 0.04748) }, { 1.2747508558137816e-06d, new GammaParticle(26359.0, 0.04704) }, { 3.626335193142974e-07d, new GammaParticle(29821.0, 0.04158) }, { 4.37698657812357e-07d, new GammaParticle(30069.0, 0.04123) }, { 7.506513849805956e-08d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    
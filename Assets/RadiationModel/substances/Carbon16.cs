using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon16 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon16";
        public override double halfLife { get; } = 0.747d;
        public override double atomicWeight { get; } = 16.0147d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen16() }, { 1.0d, new BetaParticle(-1, 4005050.0) }, { 0.0067d, new GammaParticle(120420.0, 0.0103) }, { 0.0007000000000000001d, new GammaParticle(276850.0, 0.00448) }, { 0.005d, new GammaParticle(298220.0, 0.00416) }, { 0.0003d, new GammaParticle(397270.0, 0.00312) } } },
            { 0.99d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen16() }, { 1.0d, new BetaParticle(-1, 4005050.0) }, { 0.0067d, new GammaParticle(120420.0, 0.0103) }, { 0.0007000000000000001d, new GammaParticle(276850.0, 0.00448) }, { 0.005d, new GammaParticle(298220.0, 0.00416) }, { 0.0003d, new GammaParticle(397270.0, 0.00312) } } },

        };
    }
}
    
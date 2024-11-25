using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium53";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 52.9868d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium53() }, { 1.0d, new BetaParticle(-1, 8545000.0) }, { 0.153d, new GammaParticle(2220000.0, 0.00056) } } },
            { 0.67d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium53() }, { 1.0d, new BetaParticle(-1, 8545000.0) }, { 0.153d, new GammaParticle(2220000.0, 0.00056) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium51() }, { 1.0d, new BetaParticle(-1, 943510253.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt54m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt54m";
        public override double halfLife { get; } = 88.8d;
        public override double atomicWeight { get; } = 53.94867d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese54() }, { 1.0d, new BetaParticle(1, 3872850.0) }, { 0.97d, new GammaParticle(411000.0, 0.00302) }, { 0.98d, new GammaParticle(1130000.0, 0.0011) }, { 1.0d, new GammaParticle(1407000.0, 0.00088) }, { 1.99116d, new GammaParticle(511000.0, 0.00243) }, { 5.6755656228e-05d, new GammaParticle(728.0, 1.70308) }, { 0.0006726527422291712d, new GammaParticle(6391.0, 0.194) }, { 0.0013171191349699845d, new GammaParticle(6404.0, 0.1936) }, { 0.00027220079280084445d, new GammaParticle(7082.0, 0.17507) }, { 0.00027220079280084445d, new GammaParticle(7082.0, 0.17507) } } },

        };
    }
}
    
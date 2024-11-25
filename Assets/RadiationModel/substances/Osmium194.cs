using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium194";
        public override double halfLife { get; } = 189341555.84755d;
        public override double atomicWeight { get; } = 193.96518d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium194() }, { 1.0d, new BetaParticle(-1, 48300.00001) }, { 4e-05d, new GammaParticle(39217.0, 0.03161) }, { 0.054000000000000006d, new GammaParticle(43119.0, 0.02875) }, { 0.00010999999999999999d, new GammaParticle(82339.0, 0.01506) }, { 0.17d, new GammaParticle(10728.0, 0.11557) }, { 0.00013d, new GammaParticle(63287.0, 0.01959) }, { 0.00023d, new GammaParticle(64896.0, 0.01911) }, { 8e-05d, new GammaParticle(73637.0, 0.01684) }, { 0.0001d, new GammaParticle(74510.0, 0.01664) }, { 2.2000000000000003e-05d, new GammaParticle(75576.0, 0.01641) } } },

        };
    }
}
    
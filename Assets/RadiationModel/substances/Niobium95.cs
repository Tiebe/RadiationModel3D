using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium95";
        public override double halfLife { get; } = 3023222.4d;
        public override double atomicWeight { get; } = 94.90683d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum95() }, { 1.0d, new BetaParticle(-1, 462785.0) }, { 0.00028000000000000003d, new GammaParticle(204116.1, 0.00607) }, { 0.00015d, new GammaParticle(561880.0, 0.00221) }, { 0.9980800000000001d, new GammaParticle(765803.0, 0.00162) }, { 5.5771043805924e-05d, new GammaParticle(2440.0, 0.50813) }, { 0.00028241368953309265d, new GammaParticle(17374.0, 0.07136) }, { 0.0005382384020070376d, new GammaParticle(17479.0, 0.07093) }, { 0.00014123180708827543d, new GammaParticle(19681.0, 0.063) }, { 0.00016298150537986982d, new GammaParticle(19794.0, 0.06264) }, { 2.1749698291594417e-05d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    
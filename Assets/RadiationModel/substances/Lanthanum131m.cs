using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum131m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum131m";
        public override double halfLife { get; } = 0.00017d;
        public override double atomicWeight { get; } = 130.9104d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum131() }, { 0.36450000000000005d, new GammaParticle(26200.0, 0.04732) }, { 0.10854d, new GammaParticle(108900.0, 0.01139) }, { 0.81d, new GammaParticle(169400.0, 0.00732) }, { 0.04455d, new GammaParticle(195500.0, 0.00634) }, { 0.19747535925663d, new GammaParticle(5185.0, 0.23912) }, { 0.2238685620878598d, new GammaParticle(33034.0, 0.03753) }, { 0.41122072389393793d, new GammaParticle(33442.0, 0.03707) }, { 0.12245616240479038d, new GammaParticle(37908.0, 0.03271) }, { 0.15343757149320233d, new GammaParticle(38273.0, 0.03239) }, { 0.030981409088411963d, new GammaParticle(38725.0, 0.03202) } } },

        };
    }
}
    
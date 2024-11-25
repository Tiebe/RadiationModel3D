using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt53m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt53m";
        public override double halfLife { get; } = 0.247d;
        public override double atomicWeight { get; } = 52.95761d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.985d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese53() }, { 1.0d, new BetaParticle(1, 7602600.0) }, { 1.9680600000000001d, new GammaParticle(511000.0, 0.00243) }, { 8.0117409812058e-06d, new GammaParticle(728.0, 1.70308) }, { 9.07779390643626e-05d, new GammaParticle(6391.0, 0.194) }, { 0.0001777519856361124d, new GammaParticle(6404.0, 0.1936) }, { 3.673489369902498e-05d, new GammaParticle(7082.0, 0.17507) }, { 3.673489369902498e-05d, new GammaParticle(7082.0, 0.17507) } } },
            { 0.015d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron52() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
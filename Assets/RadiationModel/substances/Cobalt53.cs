using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt53 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt53";
        public override double halfLife { get; } = 0.24d;
        public override double atomicWeight { get; } = 52.9542d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese53() }, { 1.0d, new BetaParticle(1, 6015450.0) }, { 0.055999999999999994d, new GammaParticle(1328000.0, 0.00093) }, { 2.0d, new GammaParticle(511000.0, 0.00243) }, { 8.9804919859164e-06d, new GammaParticle(728.0, 1.70308) }, { 0.00010243411549973238d, new GammaParticle(6391.0, 0.194) }, { 0.00020057590659826197d, new GammaParticle(6404.0, 0.1936) }, { 4.145177102300563e-05d, new GammaParticle(7082.0, 0.17507) }, { 4.145177102300563e-05d, new GammaParticle(7082.0, 0.17507) } } },

        };
    }
}
    
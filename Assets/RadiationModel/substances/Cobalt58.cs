using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt58 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt58";
        public override double halfLife { get; } = 6122304.0d;
        public override double atomicWeight { get; } = 57.93575d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese58() }, { 1.0d, new BetaParticle(1, -2009850.0) }, { 0.9945d, new GammaParticle(810759.3, 0.00153) }, { 0.00686205d, new GammaParticle(863951.0, 0.00144) }, { 0.0051714000000000005d, new GammaParticle(1674725.0, 0.00074) }, { 0.2980126d, new GammaParticle(511000.0, 0.00243) }, { 0.007052749945467333d, new GammaParticle(728.0, 1.70308) }, { 0.07987096393579264d, new GammaParticle(6391.0, 0.194) }, { 0.15639507330290317d, new GammaParticle(6404.0, 0.1936) }, { 0.032321193894253586d, new GammaParticle(7082.0, 0.17507) }, { 0.032321193894253586d, new GammaParticle(7082.0, 0.17507) } } },

        };
    }
}
    
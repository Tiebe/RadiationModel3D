using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin101 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin101";
        public override double halfLife { get; } = 1.7d;
        public override double atomicWeight { get; } = 100.93525d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium101() }, { 1.0d, new BetaParticle(1, 7763250.0) } } },
            { 0.26d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium100() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
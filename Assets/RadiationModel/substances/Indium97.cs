using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium97";
        public override double halfLife { get; } = 0.036d;
        public override double atomicWeight { get; } = 96.94912d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium97() }, { 1.0d, new BetaParticle(1, 6670000.0) } } },
            { 0.017d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver96() }, { 1.0d, new BetaParticle(1, 474307051.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    
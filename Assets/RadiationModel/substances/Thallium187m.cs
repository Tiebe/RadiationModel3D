using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium187m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium187m";
        public override double halfLife { get; } = 15.6d;
        public override double atomicWeight { get; } = 186.97626d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium187() } } },
            { 0.9990000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold187() }, { 1.0d, new BetaParticle(1, 5459000.0) } } },
            { 0.0015d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold183() }, { 1.0d, new AlphaParticle(6677002.09) } } },

        };
    }
}
    
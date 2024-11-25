using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium229";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 229.03496d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium229() }, { 1.0d, new BetaParticle(-1, 936000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon225() }, { 1.0d, new AlphaParticle(4625002.09) } } },

        };
    }
}
    
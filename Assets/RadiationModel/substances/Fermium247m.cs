using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium247m : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium247m";
        public override double halfLife { get; } = 5.1d;
        public override double atomicWeight { get; } = 247.07699d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium243() }, { 1.0d, new AlphaParticle(9327002.09) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium247() } } },

        };
    }
}
    
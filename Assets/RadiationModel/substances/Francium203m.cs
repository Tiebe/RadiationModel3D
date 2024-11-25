using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium203m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium203m";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 203.00133d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium203() } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine199() }, { 1.0d, new AlphaParticle(8657002.09) } } },

        };
    }
}
    
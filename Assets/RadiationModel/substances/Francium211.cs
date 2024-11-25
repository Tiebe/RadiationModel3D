using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium211";
        public override double halfLife { get; } = 186.0d;
        public override double atomicWeight { get; } = 210.99556d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine207() }, { 1.0d, new AlphaParticle(7684002.09) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon211() } } },

        };
    }
}
    
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth187m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth187m";
        public override double halfLife { get; } = 0.00037d;
        public override double atomicWeight { get; } = 186.99326d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium183() }, { 1.0d, new AlphaParticle(8909002.09) } } },

        };
    }
}
    
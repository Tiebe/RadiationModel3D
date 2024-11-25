using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth189m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth189m";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 188.98939d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium185() }, { 1.0d, new AlphaParticle(8474002.09) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth189() } } },

        };
    }
}
    
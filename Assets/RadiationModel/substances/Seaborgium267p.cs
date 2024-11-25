using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium267p : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium267p";
        public override double halfLife { get; } = 84.0d;
        public override double atomicWeight { get; } = 267.12435d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rutherfordium263() }, { 1.0d, new AlphaParticle(9667002.09) } } },

        };
    }
}
    
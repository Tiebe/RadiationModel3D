using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium258";
        public override double halfLife { get; } = 0.0025d;
        public override double atomicWeight { get; } = 258.11304d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rutherfordium254() }, { 1.0d, new AlphaParticle(10697002.09) } } },

        };
    }
}
    
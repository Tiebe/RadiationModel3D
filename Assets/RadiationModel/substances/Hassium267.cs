using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium267";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 267.13168d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium263() }, { 1.0d, new AlphaParticle(11057002.09) } } },

        };
    }
}
    
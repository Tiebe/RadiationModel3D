
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium273";
        public override double halfLife { get; } = 1.06d;
        public override double atomicWeight { get; } = 273.14146d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Seaborgium269() } },

        };
    }
}
    
    
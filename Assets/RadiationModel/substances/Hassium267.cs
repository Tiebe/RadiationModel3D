
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium267";
        public override double halfLife { get; } = 0.055d;
        public override double atomicWeight { get; } = 267.13168d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.8d, new List<RadioactiveSubstance> { new AlphaParticle(), new Seaborgium263() } },

        };
    }
}
    
    
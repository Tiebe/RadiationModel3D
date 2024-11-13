
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium271";
        public override double halfLife { get; } = 132.0d;
        public override double atomicWeight { get; } = 271.13379d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.42d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rutherfordium267() } },

            { 0.58d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    
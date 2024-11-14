using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium267";
        public override double halfLife { get; } = 108.0d;
        public override double atomicWeight { get; } = 267.12433d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new List<RadioactiveSubstance> {  } },
            { 0.17d, new List<RadioactiveSubstance> { new AlphaParticle(9645047.4), new Rutherfordium263() } },

        };
    }
}
    
    
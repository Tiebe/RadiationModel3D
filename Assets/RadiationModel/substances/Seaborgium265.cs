
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium265";
        public override double halfLife { get; } = 9.2d;
        public override double atomicWeight { get; } = 265.12109d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.5d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rutherfordium261() } },

        };
    }
}
    
    
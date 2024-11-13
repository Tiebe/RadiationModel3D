
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium261m : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium261m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 261.11606d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Seaborgium261() } },

        };
    }
}
    
    
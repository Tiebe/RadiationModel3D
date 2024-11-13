
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium240m : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium240m";
        public override double halfLife { get; } = 433.2d;
        public override double atomicWeight { get; } = 240.05618d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9987999999999999d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium240() } },

            { 0.0012d, new List<RadioactiveSubstance> { new GammaParticle(), new Neptunium240() } },

        };
    }
}
    
    
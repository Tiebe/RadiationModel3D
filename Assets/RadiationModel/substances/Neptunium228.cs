
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium228";
        public override double halfLife { get; } = 61.4d;
        public override double atomicWeight { get; } = 228.03632d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.59d, new List<RadioactiveSubstance> { new Uranium228() } },

            { 0.41d, new List<RadioactiveSubstance> { new AlphaParticle(), new Protactinium224() } },

        };
    }
}
    
    

using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium233";
        public override double halfLife { get; } = 1254.0d;
        public override double atomicWeight { get; } = 233.043d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neptunium233() } },

            { 0.0012d, new List<RadioactiveSubstance> { new AlphaParticle(), new Uranium229() } },

        };
    }
}
    
    
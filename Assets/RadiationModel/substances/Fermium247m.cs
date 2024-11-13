
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium247m : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium247m";
        public override double halfLife { get; } = 5.1d;
        public override double atomicWeight { get; } = 247.07699d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.88d, new List<RadioactiveSubstance> { new AlphaParticle(), new Californium243() } },

        };
    }
}
    
    
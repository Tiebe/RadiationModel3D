
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium203m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium203m";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 203.00133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.8d, new List<RadioactiveSubstance> { new GammaParticle(), new Francium203() } },

            { 0.2d, new List<RadioactiveSubstance> { new AlphaParticle(), new Astatine199() } },

        };
    }
}
    
    

using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium273m : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium273m";
        public override double halfLife { get; } = 0.12d;
        public override double atomicWeight { get; } = 273.14868d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Hassium269() } },

        };
    }
}
    
    
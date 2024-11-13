
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine21 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine21";
        public override double halfLife { get; } = 4.158d;
        public override double atomicWeight { get; } = 20.99995d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neon21() } },

        };
    }
}
    
    
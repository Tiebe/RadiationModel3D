using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen28 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen28";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 28.05591d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 18680000.0), new Fluorine28() } },

        };
    }
}
    
    
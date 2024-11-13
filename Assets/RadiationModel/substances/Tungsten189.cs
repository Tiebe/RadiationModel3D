
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten189 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten189";
        public override double halfLife { get; } = 696.0d;
        public override double atomicWeight { get; } = 188.96156d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhenium189() } },

        };
    }
}
    
    
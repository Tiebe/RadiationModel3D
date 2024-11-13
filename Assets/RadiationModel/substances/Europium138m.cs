
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium138m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium138m";
        public override double halfLife { get; } = 12.1d;
        public override double atomicWeight { get; } = 137.93382d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium138() } },

        };
    }
}
    
    
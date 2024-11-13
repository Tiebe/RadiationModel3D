
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic70 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic70";
        public override double halfLife { get; } = 3156.0d;
        public override double atomicWeight { get; } = 69.93093d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium70() } },

        };
    }
}
    
    
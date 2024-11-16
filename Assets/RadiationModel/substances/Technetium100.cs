using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium100";
        public override double halfLife { get; } = 15.46d;
        public override double atomicWeight { get; } = 99.90765d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3206400.0), new Ruthenium100() } },
            { 1.8e-05d, new List<RadioactiveSubstance> { new Molybdenum100() } },

        };
    }
}
    
    